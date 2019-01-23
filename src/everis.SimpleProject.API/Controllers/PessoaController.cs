using everis.SimpleProject.API.ViewModel;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers {
    public class PessoaController : BaseController<Pessoa> {


        [HttpPost("[action]")]
        public ActionResult CriarPessoaColaborador([FromServices]IGenericService<Pessoa> pessoaSvc,
             [FromServices] IAcessoFerramentaService ferramentaSvc, [FromServices] ITelefoneService telSvc,
             [FromServices] IAcessoSiglaService siglaSvc, [FromBody] PessoaColaborador pcv) {
            try {
                if (pcv.pessoa.TipoId == 1) {
                    pcv.pessoa.EmpresaId = 1;
                }
                var novaPessoa = pessoaSvc.Adicionar(pcv.pessoa);
                if (pcv.pessoa.TipoId == 1) {
                    var lstAcessoFerramenta = ferramentaSvc.AdicionarListaAcessoFerramenta(pcv.FerramentasAssociadas, novaPessoa.Colaborador.Id);
                    var lstAcessoSigla = siglaSvc.AdicionarListaAcessoSigla(pcv.SiglasAssociadas, novaPessoa.Colaborador.Id);
                }

                var lstTelefone = telSvc.AdicionarTelefones(pcv.Telefones);

                var pessoaColaborador = new PessoaColaborador {
                    pessoa = novaPessoa,
                    Telefones = lstTelefone
                };

                var retorno = new Retorno() {
                    Codigo = 200,
                    Data = pessoaColaborador

                };
                return Ok(retorno);
            }
            catch (Exception ex) {

                return BadRequest(new Retorno() {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }

        }


        [HttpGet("[action]")]
        public ActionResult ObterGestoresTecnicos([FromServices]IPessoaService pessoaSvc) {

            try {

                var gestores = pessoaSvc.ObterGestoresTecnicos();

                var retorno = new Retorno() {
                    Codigo = 200,
                    Data = gestores

                };
                return Ok(retorno);
            }
            catch (Exception ex) {

                return BadRequest(new Retorno() {
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
