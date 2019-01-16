using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers
{
    public class ProjetoPessoaController : BaseController<ProjetoPessoa>
    {
        [HttpGet("[action]/{projetoId}")]
        public IActionResult PessoasProjeto([FromServices] IProjetoPessoaService svc, int projetoId)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.PessoasProjeto(projetoId)
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