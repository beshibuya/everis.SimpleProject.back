using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace everis.SimpleProject.API.Controllers {
    public class ProjetoSquadController : BaseController<ProjetoSquad> {

        [HttpGet("[action]")]
        public virtual IActionResult ObterProjetoSquad([FromServices]IProjetoSquadService svc, ProjetoSquad filtro) {
            try {
                var retorno = new Retorno() {
                    Codigo = 200,
                    Data = svc.ObterProjetoSquad(filtro)
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
    }
}
