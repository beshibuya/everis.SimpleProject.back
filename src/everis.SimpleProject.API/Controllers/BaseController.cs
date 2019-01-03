using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace everis.SimpleProject.API.Controllers
{
    [Route("api/[controller]")]
    public abstract class BaseController<T> : Controller where T : Entity
    {
        [HttpGet("{id}")]
        public virtual IActionResult ObterPorId([FromServices]IGenericService<T> svc, int id)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.ObterPorId(id)
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

        [HttpGet("[action]")]
        public ActionResult ObterTodos([FromServices]IGenericService<T> svc)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.ObterTodos()
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

        [HttpPut("[action]/{id}")]
        public ActionResult Ativar([FromServices]IGenericService<T> svc, int id)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.Ativar(id)
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

        [HttpPut("[action]/{id}")]
        public ActionResult Desativar([FromServices]IGenericService<T> svc, int id)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.Desativar(id)
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

        [HttpDelete("{id}")]
        public ActionResult Remover([FromServices]IGenericService<T> svc, int id)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.Remover(id)
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

        [HttpPut("{id}")]
        public ActionResult Atualizar([FromServices]IGenericService<T> svc, [FromBody] T obj, int id)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.Atualizar(obj)
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

        [HttpPost]
        public ActionResult Adicionar([FromServices]IGenericService<T> svc, [FromBody] T obj)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.Adicionar(obj)
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

        [HttpGet("[action]")]
        public IActionResult BuscarPor([FromServices]IGenericService<T> svc, [FromBody]T obj)
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
