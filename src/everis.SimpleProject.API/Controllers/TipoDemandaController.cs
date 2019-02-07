using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.API.Controllers
{
    public class TipoDemandaController : BaseController<TipoDemanda>
    {
        [HttpGet("[action]/{projetoId}")]
        public IActionResult TipoDemandaProjeto([FromServices] ITipoDemandaService svc, int projetoId, bool associadas = true)

        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.TipoDemandaProjeto(projetoId, associadas)
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

        [HttpPost("[action]/{projetoId}")]
        public IActionResult AssociarTipoDemandaProjeto([FromServices]ITipoDemandaService svc, int projetoId, [FromBody] IEnumerable<TipoDemanda> TipoDemandas)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.AssociarTipoDemandaProjeto(projetoId, TipoDemandas)
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
    }
}
