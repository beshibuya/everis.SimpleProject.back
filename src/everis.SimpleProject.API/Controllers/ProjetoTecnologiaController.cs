﻿using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.API.Controllers
{
    public class ProjetoTecnologiaController : BaseController<ProjetoTecnologia>
    {
        [HttpGet("[action]/{projetoId}")]
        public IActionResult TecnologiaProjeto([FromServices] IProjetoTecnologiaService svc, int projetoId,bool associadas=true)
        
{
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.TecnologiaProjeto(projetoId, associadas)
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

        [HttpPost("[action]/{projetoId}")]
        public IActionResult AssociarTecnologiaProjeto([FromServices]IProjetoTecnologiaService svc, int projetoId,[FromBody] IEnumerable<Tecnologia> tecnologias)
        {
            try
            {
                var retorno = new Retorno()
                {
                    Codigo = 200,
                    Data = svc.AssociarTecnologiaProjeto(projetoId, tecnologias)
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