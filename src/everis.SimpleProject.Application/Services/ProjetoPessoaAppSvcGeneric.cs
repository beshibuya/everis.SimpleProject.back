using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoPessoaAppSvcGeneric : IProjetoPessoaService
    {
        //TODO: Testar

        ProjetoPessoaRepository rep = new ProjetoPessoaRepository(new AppDbContext());

        public ProjetoPessoa Adicionar(ProjetoPessoa obj)
        {
            try
            {
                rep.Adicionar(obj);
                SaveChanges();
                return obj;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public ProjetoPessoa Atualizar(ProjetoPessoa obj)
        {
            try
            {
                var currentEntity = rep.ObterPorId(obj.Id);
                currentEntity.Projeto = obj.Projeto;
                currentEntity.Pessoa = obj.Pessoa;
                rep.Atualizar(currentEntity);
                SaveChanges();

                return currentEntity;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public void Dispose()
        {
            rep.Dispose();
        }

        //public IEnumerable<ProjetoPessoa> BuscarPor(ProjetoPessoa filtro)
        //{
        //    throw new NotImplementedException();
        //}

        public ProjetoPessoa ObterPorId(int id)
        {
            try
            {
                return rep.ObterPorId(id);
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public IEnumerable<ProjetoPessoa> ObterTodos()
        {
            try
            {
                return rep.ObterTodos();
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public void Remover(int id)
        {
            try
            {
                rep.Remover(id);
                SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public int SaveChanges()
        {
            try
            {
                return rep.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            };
        }
    }
}