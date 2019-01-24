using System;
using System.Collections.Generic;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System.Linq;
using everis.SimpleProject.Data.EF;

namespace everis.SimpleProject.Application.Services {
    public class LoginAppSvcGeneric : GenericService<Colaborador>, ILoginService
    {
        GenericRepository<Pessoa> repositoryPessoa;
        public LoginAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Colaborador>(context);
            repositoryPessoa = new GenericRepository<Pessoa>(context);
        }

        public override IEnumerable<Colaborador> BuscarPor(Colaborador filter)
        {
            try
            {
                return repository.BuscarPor(b => b.EmailCorporativo == filter.EmailCorporativo && b.Senha == filter.Senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pessoa Authenticate(Colaborador filter)
        {
            var user = repository.BuscarPor(b => b.EmailCorporativo == filter.EmailCorporativo && b.Senha == filter.Senha).FirstOrDefault();
            var pessoa = repositoryPessoa.BuscarPor(b => b.ColaboradorId == user.Id).FirstOrDefault();
            //pessoa.Colaborador = user;
            return pessoa;
        }
    }
}
