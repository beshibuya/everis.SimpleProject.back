using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Repositories;
using everis.SimpleProject.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services {
    public class PessoaAppSvcGeneric : GenericService<Pessoa>, IPessoaService {
        readonly IGenericRepository<Colaborador> repColaborador;
        readonly IGenericRepository<Telefone> repTelefones;
        readonly IGenericRepository<Ferramenta> repFerramentasAssociadas;
        readonly IGenericRepository<Sigla> repSiglasAssociadas;
        readonly IGenericRepository<AcessoFerramenta> repAcessoFerramentas;
        readonly IGenericRepository<AcessoSigla> repAcessoSiglas;

        public PessoaAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<Pessoa>(context);


            repColaborador = new GenericRepository<Colaborador>(context);
            repTelefones = new GenericRepository<Telefone>(context);
            repFerramentasAssociadas = new GenericRepository<Ferramenta>(context);
            repSiglasAssociadas = new GenericRepository<Sigla>(context);
        }

        public override IEnumerable<Pessoa> ObterTodos() {
            try {

                var res = ctx.Pessoas.ToList();
                return res;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public override Pessoa ObterPorId(int id) {
            try {


                var result = repository.BuscarPor(b => b.Id == id).FirstOrDefault();
                return result;

            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public override IEnumerable<Pessoa> BuscarPor(Pessoa filter) {
            try {
                var nomeToFind = filter?.Nome;
                var result = repository.BuscarPor(b => b.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.Nome : nomeToFind));
                return result;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public IEnumerable<Pessoa> ObterGestoresTecnicos() {

            var gestores = new List<Pessoa>();
            var todasPessoas = repository.ObterTodos();

            foreach (var item in todasPessoas) {
                if (item.GestorTecnico == true) {
                    gestores.Add(item);
                }
            }

            return gestores;
        }

        public dynamic ObterPessoaColaborador(int pessoaId) {
            try {
                var pessoa = repository.ObterPorId(pessoaId);
                if (pessoa == null)
                    throw new Exception($"Pessoa com ID: {pessoaId}, não existe");


                var colaborador = repColaborador.BuscarPor(c => c.PessoaId == pessoaId).FirstOrDefault();
             

                var telefones = repTelefones.BuscarPor(t => t.PessoaId == pessoaId && t.Ativo == true, i => i.Tipo).ToList();

                var ferramentasAssociadas = colaborador != null ? (from af in ctx.AcessoFerramentas
                                                                   join f in ctx.Ferramentas on af.FerramentaId equals f.Id
                                                                   where af.Ativo && af.ColaboradorId == colaborador.Id
                                                                   select f).ToList() :
                                             new List<Ferramenta>();
                var siglasAssociadas = colaborador != null ? (from acs in ctx.AcessoSiglas
                                                              join s in ctx.Siglas on acs.SiglaId equals s.Id
                                                              where acs.Ativo && acs.ColaboradorId == colaborador.Id
                                                              select s).ToList() :
                                                              new List<Sigla>();
                dynamic result = new {
                    pessoa,
                    colaborador,
                    ferramentasAssociadas,
                    siglasAssociadas,
                    telefones
                };
                return result;
            }

            catch (Exception ex) {
                throw ex;
            }
        }

        public void AtualizarPessoaColaborador(int pessoaId, int tipoPessoa, List<Telefone> lstNovoTelefone, List<Ferramenta> lstNovaFerramenta, List<Sigla> lstNovaSigla) {
            try {

                //var colaborador = repColaborador.BuscarPor(c => c.PessoaId == pessoaId).FirstOrDefault();
                var lstTelAtual = repTelefones.BuscarPor(t => t.PessoaId == pessoaId);


                var lstferAtual = new List<Ferramenta>();
                var lstsigAtual = new List<Sigla>();

                //if (tipoPessoa == 1) {
                //    lstferAtual = colaborador != null ? (from af in ctx.AcessoFerramentas
                //                                             join f in ctx.Ferramentas on af.FerramentaId equals f.Id
                //                                             where af.Ativo && af.ColaboradorId == colaborador.Id
                //                                             select f).ToList() :
                //                                 new List<Ferramenta>();
                //    lstsigAtual = colaborador != null ? (from acs in ctx.AcessoSiglas
                //                                             join s in ctx.Siglas on acs.SiglaId equals s.Id
                //                                             where acs.Ativo && acs.ColaboradorId == colaborador.Id
                //                                             select s).ToList() :
                //                                                     new List<Sigla>();
                //}
                var lstTelToAdd = new List<Telefone>();
                //var lstFerToAdd = new List<Ferramenta>();
                //var lstSigToAdd = new List<Sigla>();
                var lstTelToRemove = new List<Telefone>();
                //var lstFerToRemove = new List<Ferramenta>();
                //var lstSigToRemove = new List<Sigla>();

                foreach (var novo in lstNovoTelefone) {
                    if (lstTelAtual.FirstOrDefault(a => a.Id == novo.Id) == null) {
                        lstTelToAdd.Add(novo);
                    }
                }


                //if (tipoPessoa == 1) {
                //    foreach (var novo in lstNovaFerramenta) {
                //        if (lstferAtual.FirstOrDefault(a => a.Id == novo.Id) == null) {
                //            lstFerToAdd.Add(novo);
                //        }
                //    }
                //    foreach (var novo in lstNovaSigla) {
                //        if (lstsigAtual.FirstOrDefault(a => a.Id == novo.Id) == null) {
                //            lstSigToAdd.Add(novo);
                //        }
                //    }
                //}


                foreach (var atual in lstTelAtual) {
                    if (lstNovoTelefone.FirstOrDefault(a => a.Id == atual.Id) == null) {
                        lstTelToRemove.Add(atual);
                    }
                }

                //if (tipoPessoa == 1) {
                //    foreach (var atual in lstferAtual) {
                //        if (lstNovaFerramenta.FirstOrDefault(a => a.Id == atual.Id) == null) {
                //            lstFerToRemove.Add(atual);
                //        }
                //    }

                //    foreach (var atual in lstsigAtual) {
                //        if (lstNovaSigla.FirstOrDefault(a => a.Id == atual.Id) == null) {
                //            lstSigToRemove.Add(atual);
                //        }
                //    }
                //}
           

                foreach (var a in lstTelToAdd) {
                    a.PessoaId = pessoaId;
                    a.Tipo = null;
                    repTelefones.Adicionar(a);
                }


                //if (tipoPessoa == 1) {

                //    foreach (var a in lstSigToAdd) {
                //        repAcessoSiglas.Adicionar(new AcessoSigla { ColaboradorId = colaborador.Id, SiglaId = a.Id });
                //    }

                //    foreach (var a in lstFerToAdd) {
                //        repAcessoFerramentas.Adicionar(new AcessoFerramenta { ColaboradorId = colaborador.Id, FerramentaId = a.Id });
                //    }

                  
                //}

                foreach (var r in lstTelToRemove) {
                    repTelefones.Desativar(r.Id);
                }

                //if (tipoPessoa == 1) {
                //    foreach (var r in lstFerToRemove) {
                //        repFerramentasAssociadas.Desativar(r.Id);
                //    }

                //    foreach (var r in lstSigToRemove) {
                //        repSiglasAssociadas.Desativar(r.Id);
                //    }
                //}
                repTelefones.SaveChanges();
                //repColaborador.SaveChanges();

                //if (tipoPessoa == 1) {
                //    repFerramentasAssociadas.SaveChanges();
                //    repSiglasAssociadas.SaveChanges();
                //    repFerramentasAssociadas.SaveChanges();
                //    repSiglasAssociadas.SaveChanges();
                //}

            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public IEnumerable<dynamic> FiltrarPessoaColaborador(Pessoa filter)
        {
            var nomeToFind = filter?.Nome;
            var data = (
                from p in ctx.Pessoas.Include(i=>i.Empresa).Include(i=>i.Tipo)
                join c in ctx.Colaboradors on p.Id equals c.PessoaId into lj
                from l in lj.DefaultIfEmpty()
                where p.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? p.Nome : nomeToFind)
                select new
                {
                    pessoa = p,
                    colaborador = l
                }
            ).ToList();

            return data;
        }
    }
}
