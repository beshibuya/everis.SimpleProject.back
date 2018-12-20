using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace everis.SimpleProject.Domain.Service
{
    public interface IGenericService<T> : IDisposable
        where T:class
    {
        T Adicionar(T obj);
        T ObterPorId(int id);
        IEnumerable<T> ObterTodos();
        T Atualizar(T obj);
        bool Remover(int id);
        T Ativar(int id);
        T Desativar(int id);
        int SaveChanges();
        void Inativar(T obj);
        void Ativar(T obj);
    }
}