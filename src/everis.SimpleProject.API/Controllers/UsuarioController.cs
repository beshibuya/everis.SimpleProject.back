using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace everis.SimpleProject.API.Controllers
{
    public class UsuarioController : BaseController<Usuario>
    {
        [HttpGet("[action]")]
        public IActionResult MetodoForaDoGenerico([FromServices]IUserService svc,[FromBody]Usuario obj)
        {
            return Ok(obj); 
        }
    }
}
