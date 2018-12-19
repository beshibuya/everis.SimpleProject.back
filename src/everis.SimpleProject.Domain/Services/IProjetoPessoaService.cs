using everis.SimpleProject.Domain.Model;
using System;

namespace everis.SimpleProject.Domain.Service
{
    interface IProjetoPessoaService : IDisposable
    {
        ProjetoPessoa Adicionar(ProjetoPessoa projetoPessoa);
        ProjetoPessoa Atualizar(ProjetoPessoa projetoPessoa);
        ProjetoPessoa Remover(int projetoPessoaId);
        ProjetoPessoa GetProjetoPessoa(int projetoPessoaId);
        ProjetoPessoa GetProjetoPessoa(ProjetoPessoa projetoPessoa);
    }
}