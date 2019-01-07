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

                var lstTelefone = pcv.pessoa.Telefones;

                pcv.pessoa.Telefones = null;
                pcv.pessoa.EmpresaId = 1;

                var novoColaborador = colaboradorSvc.Adicionar(pcv.colaborador);
                var novaPessoa = pessoaSvc.Adicionar(pcv.pessoa);

                foreach (var item in lstTelefone)
                {
                    item.PessoaId = novaPessoa.Id;
                    telSvc.Adicionar(item);
                }
                pcv.pessoa.Telefones = lstTelefone;
                pcv.pessoa.ColaboradorId = novoColaborador.Id;

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
