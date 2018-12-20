using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Service
{
    public interface IGenericService<T> where T: Entity
    {
        T Adicionar(T obj);
        T ObterPorId(int id);
        IEnumerable<T> ObterTodos();
        IEnumerable<T> BuscarPor(T filter);
        T Atualizar(T obj);
        bool Remover(int id);
        T Ativar(int id);
        T Desativar(int id);
    }
}