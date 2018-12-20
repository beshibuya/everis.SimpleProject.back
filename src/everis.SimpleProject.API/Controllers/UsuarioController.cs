using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using everis.SimpleProject.Application.Services;
using everis.SimpleProject.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace everis.SimpleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {



        //[HttpGet]
        //public ActionResult ObterTodos()
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
        //    var retorno = svc.ObterTodos();
        //    return Json(retorno);
        //}

        //[HttpGet]
        //public ActionResult ObterPorId(int id)
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
        //    var retorno = svc.ObterPorId(id);
        //    return Json(retorno);
        //}

        //[HttpPost]
        //public ActionResult Ativar(int id)
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
        //    var retorno = svc.Ativar(id);
        //    return Json(retorno);
        //}

        //[HttpPost]
        //public ActionResult Desativar(int id)
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
        //    var retorno = svc.Desativar(id);
        //    return Json(retorno);
        //}

        //[HttpPost]
        //public ActionResult Remover(int id)
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
        //    var retorno = svc.Remover(id);
        //    return Json(retorno);
        //}

        //[HttpPost]
        //public void Atualizar([FromBody] Usuario obj)
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
        //    var retorno = svc.Atualizar(obj);
        //    return Json(retorno);
        //}

        //[HttpPost]
        //public void Adicionar([FromBody] Usuario obj)
        //{
        //    UsuarioAppSvcGeneric svc = new UsuarioAppSvcGeneric();
        //    var retorno = svc.Adicionar(obj);
        //    return Json(retorno);
        //}

    }
}
