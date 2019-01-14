using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Repositories;
using everis.SimpleProject.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoAppSvcGeneric : GenericService<Projeto>, IProjetoService
    {
        readonly IGenericRepository<Fase> repFase;
        readonly IGenericRepository<SolicitacaoMudanca> repChanges;
        public ProjetoAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Projeto>(context);
            repChanges = new GenericRepository<SolicitacaoMudanca>(context);
            repFase = new GenericRepository<Fase>(context);
        }

        public override Projeto ObterPorId(int id)
        {
            var res = ctx.Projetos.Include(i => i.ProjetosPessoas).FirstOrDefault(f => f.Id == id);
            return res;
        }

        public override IEnumerable<Projeto> ObterTodos()
        {
            return BuscarPor(new Projeto());
        }
        //TODO: Testar
        public override IEnumerable<Projeto> BuscarPor(Projeto filter)
        {
            try
            {
                var nomeToFind = filter?.Nome;
                var result = repository.BuscarPor(b => b.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.Nome : nomeToFind
                    ));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> ListarProjetosComChange(Projeto filtro)
        {
            var nomeFind = filtro?.Nome;
            var data = (from ch in ctx.Changes
                        join pj in ctx.Projetos on ch.ProjetoId equals pj.Id
                        //where pj.Nome.Contains(string.IsNullOrEmpty(nomeFind)?pj.Nome:nomeFind)
                        select ch).ToList();
            var lstProjeto = (
                from d in data
                group d by d.ProjetoId into g
                join pj in ctx.Projetos on g.Key equals pj.Id
                select pj
                ).ToList();
            var lstResult = new List<dynamic>();
            foreach (var p in lstProjeto)
            {
                lstResult.Add(new
                {
                    projeto = p,
                    changes = data.Where(w => w.ProjetoId == p.Id)
                });
            }
            return lstResult;
        }

        public IEnumerable<dynamic> ListarProjetosComFase(Projeto filtro)
        {
            var nomeFind = filtro?.Nome;
            var data = (from ep in ctx.Fases
                        join pp in ctx.ProjetoPessoas.Include(i => i.Projeto).Include(i => i.Pessoa)
                            on ep.ProjetoPessoaId equals pp.Id
                        select new
                        {
                            pp.ProjetoId,
                            NomeProjeto = pp.Projeto.Nome,
                            pp.Pessoa,
                            ep.DataInicio,
                            ep.DataFim,
                            ep.QtdHorasDia
                        }).Where(pp => pp.ProjetoId == filtro.Id).ToList();

            return data;
        }
    }
}
