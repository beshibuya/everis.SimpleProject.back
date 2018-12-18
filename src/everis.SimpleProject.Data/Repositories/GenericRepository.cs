using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T:Entity
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }


        public T Adicionar(T obj)
        {
            _dbSet.Add(obj);
            return obj;
        }

        public T Atualizar(T obj)
        {
            var entity = _dbContext.Set<T>().Single(x => x.Id == obj.Id);

            _dbContext.Entry(entity).State = EntityState.Detached;
            _dbContext.Entry(entity).State = EntityState.Detached;
            
            _dbContext.Set<T>().Update(obj);

            return obj;
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
