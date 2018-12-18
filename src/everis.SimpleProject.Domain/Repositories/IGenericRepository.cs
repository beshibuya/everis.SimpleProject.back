using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace everis.SimpleProject.Domain.Repositories
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        TEntity Atualizar(TEntity obj);
        void Remover(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}