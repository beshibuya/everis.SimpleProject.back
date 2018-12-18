using everis.SimpleProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace everis.SimpleProject.Domain.Service
{
    interface IUsuarioService : IDisposable
    {
        Usuario Adicionar(Usuario obj);
        Usuario ObterPorId(int id);
        IEnumerable<Usuario> ObterTodos();
        Usuario Atualizar(Usuario obj);
        void Remover(int id);
        IEnumerable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicate);
        int SaveChanges();
    }
}