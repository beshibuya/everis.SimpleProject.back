using everis.SimpleProject.CrossCutting;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public virtual ActionResult ObterTodos([FromServices]IGenericService<T> svc)
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
        public virtual ActionResult Ativar([FromServices]IGenericService<T> svc, int id)
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
        public virtual ActionResult Desativar([FromServices]IGenericService<T> svc, int id)
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
        public virtual ActionResult Remover([FromServices]IGenericService<T> svc, int id)
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
        public virtual ActionResult Atualizar([FromServices]IGenericService<T> svc, [FromBody] T obj, int id)
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
        public virtual ActionResult Adicionar([FromServices]IGenericService<T> svc, [FromBody] T obj)
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
        public virtual IActionResult BuscarPor([FromServices]IGenericService<T> svc, T obj)
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

        [HttpGet("[action]")]
        public virtual IActionResult Exportar([FromServices]IGenericService<T> svc, T obj, string tipoArquivo = "csv", List<int> campos = null)
        {
            try
            {
                var listaFiltrada = svc.BuscarPor(obj);

                if (!listaFiltrada.Any())
                {
                    var retorno = new Retorno()
                    {
                        Codigo = 200,
                        Data = null,
                        Mensagem = "Não foram localizados registros para este filtro!"
                    };
                    return Ok(retorno);
                }
                else
                {
                    var isCsv = tipoArquivo.Equals("csv");
                    var isXls = tipoArquivo.Equals("xls");
                    if (!isCsv && !isXls)
                    {
                        return BadRequest(
                            new Retorno
                            {
                                Codigo = 500,
                                Sucesso = false,
                                Mensagem = "Formato de arquivo inválido!"
                            });
                    }

                    var mimeTypeRetorno = $"application/{(isCsv ? "csv" : "vnd.ms-excel")}";

                    var byteArrayParaExportar = ExportarParaTabela<T>.GerarArquivoExportar(listaFiltrada, campos, isCsv);
                    var resultadoArquivo = new FileContentResult(byteArrayParaExportar, mimeTypeRetorno)
                    {
                        FileDownloadName = $"Export_{typeof(T).Name}_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.{tipoArquivo}"
                    };

                    var retorno = new Retorno()
                    {
                        Codigo = 200,
                        Data = resultadoArquivo
                    };
                    return Ok(retorno);
                }

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
