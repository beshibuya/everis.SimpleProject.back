using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.API.Controllers
{
    public class ProjetoSiglaController : BaseController<ProjetoSigla>
    {
        [HttpGet("[action]/{projetoId}")]
        public IActionResult SiglaProjeto([FromServices] IProjetoSiglaService svc, int projetoId, bool associadas = true)

        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.SiglaProjeto(projetoId, associadas)
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
        public IActionResult AssociarSiglaProjeto([FromServices]IProjetoSiglaService svc, int projetoId, [FromBody] IEnumerable<Sigla> siglas)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.AssociarSiglaProjeto(projetoId, siglas)
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
