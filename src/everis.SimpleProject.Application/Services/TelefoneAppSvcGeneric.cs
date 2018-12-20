using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services
{
    public class TelefoneAppSvcGeneric : ITelefoneService
    {
        //TODO: Testar

        TelefoneRepository rep = new TelefoneRepository(new AppDbContext());

        public Telefone Adicionar(Telefone obj)
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

        public Telefone Atualizar(Telefone obj)
        {
            try
            {
                var currentEntity = rep.ObterPorId(obj.Id);
                currentEntity.NumeroTelefone = obj.NumeroTelefone;
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
        public Telefone Desativar(int id)
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

        public Telefone Ativar(int id)
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
        public void Dispose()
        {
            rep.Dispose();
        }

        public Telefone ObterPorId(int id)
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

        public IEnumerable<Telefone> ObterTodos()
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
            catch (Exception e)
            {
                throw;
            };
        }
    }
}
