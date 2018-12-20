using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:Entity
    {
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public T Adicionar(T obj)
        {
            _dbContext.Add(obj);
            return obj;
        }

        public T Desativar(int Id)
        {
            var entity = _dbContext.Set<T>().Find(Id);
            entity.DataInativacao = DateTime.Now;
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public T Ativar(int Id)
        {
            var entity = _dbContext.Set<T>().Find(Id);
            entity.DataInativacao = null;
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public T Atualizar(T obj)
        {
            var entity = GetById(obj.Id);
            if (entity == null)
                return entity;

            _dbContext.Entry(entity).State = EntityState.Modified;
            return obj;
        }

        private T GetById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(f => f.Id == id);
        }

        public IQueryable<T> BuscarPor(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includes)
        {
            var currentSet = _dbContext.Set<T>();
            IQueryable<T> query = currentSet;
            foreach (var inc in includes)
                query = query.Include(inc);
            return query.Where(predicate);
        }

        public T ObterPorId(int id)
        {
            return GetById(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _dbContext.Set<T>().ToList();
        }

        public bool Remover(int id)
        {
            _dbContext.Set<T>().Remove(ObterPorId(id));
            var returno = _dbContext.SaveChanges();

            return returno == 1;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }


        public void Inativar(T toUpdate) => _dbContext.Entry(toUpdate).State = EntityState.Modified;

        public void Ativar(T toUpdate) => _dbContext.Entry(toUpdate).State = EntityState.Modified;
    }
}
