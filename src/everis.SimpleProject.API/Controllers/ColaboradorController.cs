using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers
{
    public class ColaboradorController : BaseController<Colaborador>
    {
        [HttpGet("[action]/{colaboradorId}")]
        public IActionResult ListarFerramentasDisponiveis([FromServices]IColaboradorService svc, int colaboradorId)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.ListarFerramentasDisponiveis(colaboradorId)
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


        [HttpGet("[action]/{colaboradorId}")]
        public IActionResult ListarFerramentasAssociadas([FromServices]IColaboradorService svc, int colaboradorId)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.ListarFerramentasAssociadas(colaboradorId)
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
