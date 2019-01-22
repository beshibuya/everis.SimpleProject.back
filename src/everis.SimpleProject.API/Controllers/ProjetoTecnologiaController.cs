using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers
{
    public class ProjetoTecnologiaController : BaseController<ProjetoTecnologia>
    {
        [HttpGet("[action]/{projetoId}")]
        public IActionResult TecnologiaProjeto([FromServices] IProjetoTecnologiaService svc, int projetoId)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.TecnologiaProjeto(projetoId)
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