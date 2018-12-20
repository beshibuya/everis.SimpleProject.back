using everis.SimpleProject.Application.Services;
using everis.SimpleProject.Domain.Models;
using System;
using System.Linq;
using Xunit;

namespace everis.SimpleProject.Application.Tests
{

    public class UsuarioTests
    {
        [Fact]
        public void AdicionarTest()
        {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            var usuario = new Usuario {
                DataCadastro = DateTime.Now,
                Email = "email@teste4.com",
                NomeUsuario = "TestUser4",
                Senha = "456",
                SenhaTemporaria = true
            };
            var retorno = svc.Adicionar(usuario);
            Assert.NotNull(retorno);
        }

        [Fact]
        public void AtualizarTest() {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            var usuario = new Usuario {
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
        public void ObterPorIdTest() {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            var retorno = svc.ObterPorId(1);
            Assert.NotNull(retorno);
        }

        [Fact]
        public void ObterTodosTest() {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            var retorno = svc.ObterTodos();
            Assert.True(retorno.Count() > 0);
        }


        [Fact]
        public void RemoverTest() {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            svc.Remover(3);

        }


        [Fact]
        public void SaveChangesTest() {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            var retorno = svc.SaveChanges();
            Assert.True(retorno == 0);

        }

        [Fact]
        public void DisposeTest() {
            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            svc.Dispose();

        }


        [Fact]
        public void InativarTest()
        {
            var usuario = new Usuario
            {
                Id = 1,
            };


            UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
            svc.Inativar(usuario);
           
        }
    }
}
