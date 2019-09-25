using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.API.Models.Repositories;
using ControleDeProjetos.Dominio.Argumentos.Gerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControleDeProjetos.API.Controllers
{
    public class GerenciaController : ApiController
    {
        static readonly IGerenciaRepositorio repositorio = new GerenciaRepositorio();

        [HttpGet]
        [Route("Mostra")]
        public IEnumerable<GerenciaResponse> Mostra()
        {
            return repositorio.Mostra();
        }

        [HttpGet]
        [Route("MostraCodigo")]
        public Gerencia MostraByCodigo(string codigo)
        {
            Gerencia item = repositorio.MostraByCodigo(codigo);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        [Route("Gravar")]
        public IHttpActionResult Gravar(Gerencia request)
        {
            GerenciaResponse response = null;
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
        public void Altera(Guid id, Gerencia gerencia)
        {
            gerencia.IDGerencia = id;
            if (!repositorio.Atualiza(gerencia))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("Apagar")]
        public void Apaga(string Codigo)
        {
            Gerencia item = repositorio.MostraByCodigo(Codigo);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Apaga(Codigo);
        }
    }
}
