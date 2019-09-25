using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.API.Models.Repositories;
using ControleDeProjetos.Dominio.Argumentos.Nota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControleDeProjetos.API.Controllers
{
    public class NotaController : ApiController
    {
        static readonly INotaRepositorio repositorio = new NotaRepositorio();

        [HttpGet]
        [Route("Mostra")]
        public IEnumerable<NotaResponse> Mostra()
        {
            return repositorio.Mostra();
        }

        [HttpGet]
        [Route("MostraCodigo")]
        public Nota MostraByCodigo(string codigo)
        {
            Nota item = repositorio.MostraByCodigo(codigo);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        [Route("Gravar")]
        public IHttpActionResult Gravar(Nota request)
        {
            NotaResponse response = null;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                response = repositorio.Gravar(request);
            }
            catch (Exception)
            {
                throw;
            }


            return Ok(response);

        }

        [HttpPut]
        [Route("Alterar")]
        public void Altera(Guid id, Nota nota)
        {
            nota.IDNota = id;
            if (!repositorio.Atualiza(nota))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("Apagar")]
        public void Apaga(string Codigo)
        {
            Nota item = repositorio.MostraByCodigo(Codigo);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Apaga(Codigo);
        }
    }
}
