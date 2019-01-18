using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using everis.SimpleProject.Domain.Services;

namespace everis.SimpleProject.API.Controllers
{
    public class TelefoneController : BaseController<Telefone>
    {

        [HttpPost("[action]")]
        public virtual IActionResult AdicionarTelefones([FromServices] ITelefoneService svc, [FromBody] List<Telefone> telefones) {
            try {
                var retorno = new Retorno() {
                    Codigo = 200,
                    Data = svc.AdicionarTelefones(telefones)
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
