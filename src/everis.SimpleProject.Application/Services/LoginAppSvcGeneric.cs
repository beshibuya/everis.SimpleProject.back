using System;
using System.Collections.Generic;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using everis.SimpleProject.Domain.Services;
using System.Linq;
using everis.SimpleProject.Data.EF;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace everis.SimpleProject.Application.Services
{
    public class LoginAppSvcGeneric : GenericService<Colaborador>, ILoginService
    {
        public LoginAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Colaborador>(context);
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

        public Colaborador Authenticate(Colaborador filter)
        {
            var user = repository.BuscarPor(b => b.EmailCorporativo == filter.EmailCorporativo && b.Senha == filter.Senha).FirstOrDefault();
            
            return user;
        }
    }
}
