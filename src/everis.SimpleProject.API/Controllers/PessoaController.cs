using everis.SimpleProject.API.ViewModel;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers
{
    public class PessoaController : BaseController<Pessoa>
    {


        [HttpPost("[action]")]
        public ActionResult CriarPessoaColaborador([FromServices]IGenericService<Pessoa> pessoaSvc,
            [FromServices] IGenericService<Colaborador> colaboradorSvc,
             [FromServices] IAcessoFerramentaService ferramentaSvc, [FromServices] ITelefoneService telSvc,
             [FromServices] IAcessoSiglaService siglaSvc, [FromBody] PessoaColaborador pcv)
        {
            try
                {
                var novoColaborador = new Colaborador();
                if (pcv.pessoa.TipoId == 1)
                {
                    pcv.pessoa.EmpresaId = 1;
                }
                var novaPessoa = pessoaSvc.Adicionar(pcv.pessoa);
                pcv.colaborador.PessoaId = novaPessoa.Id;
                if (pcv.pessoa.TipoId == 1)
                {
                    novoColaborador = colaboradorSvc.Adicionar(pcv.colaborador);
                    var lstAcessoFerramenta = ferramentaSvc.AdicionarListaAcessoFerramenta(pcv.FerramentasAssociadas, novoColaborador.Id);
                    var lstAcessoSigla = siglaSvc.AdicionarListaAcessoSigla(pcv.SiglasAssociadas, novoColaborador.Id);
                }

                var lstTelefone = telSvc.AdicionarTelefones(pcv.Telefones, novaPessoa.Id);

                return Ok(new Retorno()
                {
                    Codigo = 200,
                    Data = new PessoaColaborador
                    {
                        pessoa = novaPessoa,
                        colaborador = novoColaborador,
                        Telefones = lstTelefone
                    }
                });
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


        [HttpPut("[action]")]
        public ActionResult AtualizarPessoaColaborador([FromServices] IGenericService<Pessoa> genPessoaSvc,
            [FromServices] IGenericService<Colaborador> genColaboradorSvc,
            [FromServices] IPessoaService pessoaSvc, [FromBody] PessoaColaborador pcv)
        {
            try
            {

                if (pcv.pessoa.TipoId == 1)
                {
                    pcv.pessoa.EmpresaId = 1;
                }

                var pessoaEditadda = genPessoaSvc.Atualizar(pcv.pessoa);
                if (pcv.pessoa.TipoId == 1)
                {
                    genColaboradorSvc.Atualizar(pcv.colaborador);
                }
                pessoaSvc.AtualizarPessoaColaborador(pcv.pessoa.Id, pcv.pessoa.TipoId, pcv.Telefones, pcv.FerramentasAssociadas, pcv.SiglasAssociadas);

                return Ok(new Retorno()
                {
                    Codigo = 200,
                    Data = "Edição realizada com sucesso"
                });


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


        [HttpGet("[action]")]
        public ActionResult ObterGestoresTecnicos([FromServices]IPessoaService pessoaSvc)
        {

            try
            {

                var gestores = pessoaSvc.ObterGestoresTecnicos();

                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = gestores

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

        [HttpGet("[action]/{pessoaId}")]
        public IActionResult ObterPessoaColaborador([FromServices]IPessoaService svc, int pessoaId)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.ObterPessoaColaborador(pessoaId)
                };
                return Ok(retorno);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }

        [HttpGet("[action]")]
        public IActionResult FiltrarPessoaColaborador([FromServices]IPessoaService svc, Pessoa filter)
        {
            try
            {
                var result = new Retorno
                {
                    Codigo = 200,
                    Data = svc.FiltrarPessoaColaborador(filter)
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new Retorno { Codigo = 500, Mensagem = ex.Message });
            }
        }

    }
}
