using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class UsuarioAppSvcGeneric : GenericService<Usuario>, IUserService
    {
        public UsuarioAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Usuario>(context);
        }

        //TODO: Testar
        public override IEnumerable<Usuario> BuscarPor(Usuario filter)
        {
            try
            {
                var nomeToFind = filter?.NomeUsuario;
                var result = repository.BuscarPor(b => b.NomeUsuario.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.NomeUsuario : nomeToFind
                    ));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Usuario> MetodoForaDoGenerico()
        {
            throw new NotImplementedException();
        }
    }
}
