using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace everis.SimpleProject.Domain.Repositories
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        TEntity Atualizar(TEntity obj);
        bool Remover(int id);
        IQueryable<TEntity> BuscarPor(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        TEntity Desativar(int Id);
        TEntity Ativar(int Id);
        int SaveChanges();
        void Inativar(TEntity obj);
        void Ativar(TEntity obj);
    }
}