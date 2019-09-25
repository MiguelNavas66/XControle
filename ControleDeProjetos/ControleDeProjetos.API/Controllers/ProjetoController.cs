using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.API.Models.Repositories;
using ControleDeProjetos.Dominio.Argumentos.Projeto;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace ControleDeProjetos.API.Controllers
{
    public class ProjetoController : ApiController
    {
        static readonly IProjetoRepositorio repositorio = new ProjetoRepositorio();

        [HttpGet]
        [Route("Mostra")]
        public IEnumerable<ProjetoResponse> Mostra()
        {
            return repositorio.Mostra();
        }

        [HttpGet]
        [Route("MostraCodigo")]
        public Projeto MostraByCodigo(string codigo)
        {
            Projeto item = repositorio.MostraByCodigo(codigo);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        [Route("Gravar")]
        public IHttpActionResult Gravar(Projeto request)
        {
            ProjetoResponse response = null;
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
        public void Altera(Guid id, Projeto projeto)
        {
            projeto.IDProjeto = id;
            if (!repositorio.Atualiza(projeto))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("Apagar")]
        public void Apaga(string Codigo)
        {
            Projeto item = repositorio.MostraByCodigo(Codigo);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Apaga(Codigo);
        }
    }
}
