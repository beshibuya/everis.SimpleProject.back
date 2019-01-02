using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace everis.SimpleProject.API.Controllers
{
    public class EmpresaController : BaseController<Empresa>
    {
        [HttpGet("[action]")]
        public IActionResult BuscarPor([FromServices]IEmpresaService svc, [FromBody]Empresa obj)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.BuscarPor(obj)
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
