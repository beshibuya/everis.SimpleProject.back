using System;
using System.Collections.Generic;
using System.IO;
using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Repositories;
using everis.SimpleProject.Domain.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Application.Services
{
    public abstract class GenericService<T> : IGenericService<T> where T : Entity
    {
        protected IGenericRepository<T> repository;
        private readonly DbContext _context;
        protected AppDbContext ctx => _context as AppDbContext;

        public GenericService(DbContext context)
        {
            repository = new GenericRepository<T>(context);
            _context = context;
        }

        public virtual T Adicionar(T obj)
        {
            try
            {
                repository.Adicionar(obj);
                repository.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual T Ativar(int id)
        {
            try
            {
                var obj = repository.Ativar(id);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual T Atualizar(T obj)
        {
            try
            {
                var current = repository.ObterPorId(obj.Id);
                current.MergeFrom(obj);
                repository.Atualizar(current);
                repository.SaveChanges();
                return current;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Exportar(IEnumerable<T> listaFiltrada, List<string> camposExportar)
        {
            try
            {
                //var current = repository.ObterPorId(obj.Id);
                //current.MergeFrom(obj);
                //repository.Atualizar(current);
                //repository.SaveChanges();
                //return current;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public virtual T Desativar(int id)
        {
            try
            {
                var obj = repository.Desativar(id);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public abstract IEnumerable<T> BuscarPor(T filter);

        public virtual T ObterPorId(int id)
        {
            try
            {
                return repository.ObterPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<T> ObterTodos()
        {
            try
            {
                return repository.ObterTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool Remover(int id)
        {
            try
            {
                var obj = repository.Remover(id);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
