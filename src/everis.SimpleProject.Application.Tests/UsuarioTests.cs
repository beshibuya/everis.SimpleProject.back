using everis.SimpleProject.Application.Services;
using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Domain.Models;
using System;
using System.Linq;
using Xunit;

namespace everis.SimpleProject.Application.Tests
{
    //TODO: Rever testes devido AppDbContext
    public class UsuarioTests
    {
        AppDbContext context = new AppDbContext();
        [Fact]
        public void AdicionarTest()
        {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
            var usuario = new Usuario
            {
                DataCadastro = DateTime.Now,
                Email = "email@teste4.com",
                NomeUsuario = "TestUser4",
                Senha = "456",
                SenhaTemporaria = true,
                DataInativacao = null

            };
            var retorno = svc.Adicionar(usuario);
            Assert.NotNull(retorno);
        }

        [Fact]
        public void AtualizarTest()
        {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
            var usuario = new Usuario
            {
                Id = 1,
                DataCadastro = DateTime.Now,
                Email = "email@teste.com",
                NomeUsuario = "TestUserUpdated",
                Senha = "789",
                SenhaTemporaria = true
            };
            var retorno = svc.Atualizar(usuario);
            Assert.NotNull(retorno);
        }


        [Fact]
        public void ObterPorIdTest()
        {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
            var retorno = svc.ObterPorId(1);
            Assert.NotNull(retorno);
        }

        [Fact]
        public void ObterTodosTest()
        {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
            var retorno = svc.ObterTodos();
            Assert.True(retorno.Count() > 0);
        }


        [Fact]
        public void RemoverTest()
        {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
            svc.Remover(3);

        }


        //[Fact]
        //public void SaveChangesTest()
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
        //    var retorno = svc.SaveChanges();
        //    Assert.True(retorno == 0);

        //}

        //[Fact]
        //public void DisposeTest()
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
        //    svc.Dispose();

        //}


        [Fact]
        public void InativarTest()
        {

            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric(context);
            svc.Desativar(1);

        }
    }
}
