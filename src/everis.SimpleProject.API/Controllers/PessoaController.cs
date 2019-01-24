using everis.SimpleProject.API.ViewModel;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers
{
    public class PessoaController : BaseController<Pessoa>
    {


        [HttpPost("[action]")]
        public ActionResult CriarPessoaColaborador([FromServices]IGenericService<Pessoa> pessoaSvc,
            [FromServices] IGenericService<Colaborador> colaboradorSvc, [FromServices] IGenericService<Telefone> telSvc, [FromBody] PessoaColaborador pcv)
        {
            try
            {              
                pcv.pessoa.EmpresaId = 1;
                var novoColaborador = colaboradorSvc.Adicionar(pcv.colaborador);
                pcv.pessoa.ColaboradorId = novoColaborador.Id;
                var novaPessoa = pessoaSvc.Adicionar(pcv.pessoa);

                var pessoaColaborador = new PessoaColaborador
                {
                    pessoa = novaPessoa,
                    colaborador = novoColaborador
                };

                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = pessoaColaborador

                };
                return Ok(retorno);
            }
            catch (Exception ex)
            {

                return BadRequest(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }

        }

        //[HttpGet("[action]/{colaboradorId}")]
        //public IActionResult ListarDadosColaborador([FromServices]IGenericService<Pessoa> svc, string email)
        //{
        //    try
        //    {
        //        var retorno = new Retorno()
        //        {
        //            Codigo = 200,
        //            Data = svc.ListarDadosColaborador(email)
        //        };
        //        return Ok(retorno);

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new Retorno()
        //        {
        //            Codigo = 500,
        //            Mensagem = ex.Message
        //        });
        //    }
        //}


        //[HttpGet("[action]")]
        //public ActionResult ObterPessoasColaboradores([FromServices] IGenericService<Colaborador> svcColaborador, [FromServices] IGenericService<Pessoa> svcPessoa)
        //{
        //    try
        //    {
        //        var dbColborador = svcColaborador.ObterTodos();

        //        foreach (var item in dbColborador)
        //        {
        //            item.Pessoa = svcPessoa.ObterPorId(item.PessoaId);
        //        }

        //        var retorno = new Retorno()
        //        {
        //            Codigo = 200,
        //            Data = dbColborador

        //        };
        //        return Ok(retorno);
        //    }
        //    catch (Exception ex)
        //    {

        //        return BadRequest(new Retorno()
        //        {
        //            Codigo = 500,
        //            Mensagem = ex.Message
        //        });
        //    }


        //}


    }
}
