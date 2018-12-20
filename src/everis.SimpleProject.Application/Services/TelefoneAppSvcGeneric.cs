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
