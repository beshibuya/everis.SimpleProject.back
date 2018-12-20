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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProjetoPessoa Desativar(int id)
        {
            try
            {
                var obj = rep.Desativar(id);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProjetoPessoa Ativar(int id)
        {
            try
            {
                var obj = rep.Ativar(id);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ProjetoPessoa> ObterTodos()
        {
            try
            {
                return rep.ObterTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remover(int id)
        {
            try
            {
                var obj = rep.Remover(id);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveChanges()
        {
            try
            {
                return rep.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}