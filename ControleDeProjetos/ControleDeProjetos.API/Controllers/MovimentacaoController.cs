using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.API.Models.Repositories;
using ControleDeProjetos.Dominio.Argumentos.Movimentacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControleDeProjetos.API.Controllers
{
    public class MovimentacaoController : ApiController
    {
        static readonly IMovimentacaoRepositorio repositorio = new MovimentacaoRepositorio();

        [HttpGet]
        [Route("Mostra")]
        public IEnumerable<MovimentacaoResponse> Mostra()
        {
            return repositorio.Mostra();
        }

        [HttpGet]
        [Route("MostraCodigo")]
        public Movimentacao MostraByCodigo(string codigo)
        {
            Movimentacao item = repositorio.MostraByCodigo(codigo);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        [Route("Gravar")]
        public IHttpActionResult Gravar(Movimentacao request)
        {
            MovimentacaoResponse response = null;
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
        public void Altera(Guid id, Movimentacao movimentacao)
        {
            movimentacao.IDMovimentacao = id;
            if (!repositorio.Atualiza(movimentacao))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("Apagar")]
        public void Apaga(string Codigo)
        {
            Movimentacao item = repositorio.MostraByCodigo(Codigo);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Apaga(Codigo);
        }

    }
}
