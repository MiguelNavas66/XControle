using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.API.Models.Repositories;
using ControleDeProjetos.Dominio.Argumentos.Ordem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControleDeProjetos.API.Controllers
{
    public class OrdemController : ApiController
    {
        static readonly IOrdemRepositorio repositorio = new OrdemRepositorio();

        [HttpGet]
        [Route("Mostra")]
        public IEnumerable<OrdemResponse> Mostra()
        {
            return repositorio.Mostra();
        }

        [HttpGet]
        [Route("MostraCodigo")]
        public Ordem MostraByCodigo(string codigo)
        {
            Ordem item = repositorio.MostraByCodigo(codigo);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        [Route("Gravar")]
        public IHttpActionResult Gravar(Ordem request)
        {
            OrdemResponse response = null;
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
        public void Altera(Guid id, Ordem ordem)
        {
            ordem.IDOrdem = id;
            if (!repositorio.Atualiza(ordem))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("Apagar")]
        public void Apaga(string Codigo)
        {
            Ordem item = repositorio.MostraByCodigo(Codigo);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Apaga(Codigo);
        }
    }
}
