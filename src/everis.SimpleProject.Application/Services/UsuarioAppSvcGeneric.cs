using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace everis.SimpleProject.Application.Services
{
    public class UsuarioAppSvcGeneric : IUsuarioService
    {

        //TODO: Testar

        UsuarioRepository rep = new UsuarioRepository(new AppDbContext());

        public Usuario Adicionar(Usuario obj)
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

     

        public Usuario Atualizar(Usuario obj)
        {
            try
            {
                var currentEntity = rep.ObterPorId(obj.Id);
                currentEntity.Email = obj.Email;
                currentEntity.NomeUsuario = obj.NomeUsuario;
                currentEntity.Senha = obj.Senha;
                rep.Atualizar(currentEntity);
                SaveChanges();

                return currentEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario Desativar(int id)
        {
            try
            {
                var obj  = rep.Desativar(id);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario Ativar(int id)
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

        //public IEnumerable<Usuario> BuscarPor(Usuario filtro)
        //{
        //    throw new NotImplementedException();
        //}

        public void Dispose()
        {
            rep.Dispose();
        }

     

        public Usuario ObterPorId(int id)
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

        public IEnumerable<Usuario> ObterTodos()
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
            catch(Exception ex)
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
            };
        }
    }
}
