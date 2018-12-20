using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using everis.SimpleProject.Application.Services;
using everis.SimpleProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace everis.SimpleProject.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        [HttpGet]
        [ActionName("obtertodos")]
        public ActionResult ObterTodos()
        {
            try
            {
                UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = JsonConvert.SerializeObject(svc.ObterTodos())
                };
                return Ok(retorno);

            }
            catch (Exception ex)
            {

                return Ok(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }

        [HttpGet]
        public ActionResult ObterPorId(int id)
        {
            try
            {
                UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();

                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = JsonConvert.SerializeObject(svc.ObterPorId(id))
                };
                return Ok(retorno);

            }
            catch (Exception ex)
            {

                return Ok(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }

        [HttpGet]
        public ActionResult Ativar(int id)
        {
            try
            {
                UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();

                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = JsonConvert.SerializeObject(svc.Ativar(id))
                };
                return Ok(retorno);

            }
            catch (Exception ex)
            {

                return Ok(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }

        [HttpGet]
        public ActionResult Desativar(int id)
        {
            try
            {
                UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = JsonConvert.SerializeObject(svc.Desativar(id))
                };
                return Ok(retorno);

            }
            catch (Exception ex)
            {

                return Ok(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }

        [HttpDelete]
        public ActionResult Remover(int id)
        {
            try
            {
                UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = JsonConvert.SerializeObject(svc.Remover(id))
                };
                return Ok(retorno);

            }
            catch (Exception ex)
            {

                return Ok(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }

        [HttpPost]
        public ActionResult Atualizar([FromBody] Usuario obj)
        {
            try
            {
                UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = JsonConvert.SerializeObject(svc.Atualizar(obj))
                };
                return Ok(retorno);

            }
            catch (Exception ex)
            {

                return Ok(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] Usuario obj)
        {
            try
            {
                UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = JsonConvert.SerializeObject(svc.Adicionar(obj))
                };
                return Ok(retorno);
            }
            catch (Exception ex)
            {

                return Ok(new Retorno()
                {
                    Codigo = 500,
                    Mensagem = ex.Message
                });
            }

        }

    }
}
