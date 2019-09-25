using ControleDeProjetos.API.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControleDeProjetos.API.Controllers
{
    [RoutePrefix("Api/Fornecedor")]
    public class FornecedorController : ApiController
    {

        public static readonly IFornecedorRepositorio repositorio = new FornecedorRepositorio();

        [HttpGet]
        [Route("AllFornecedor")]
        public IEnumerable<Fornecedor> GetAllFornecedor()
        {
            return repositorio.GetAll();
        }

        [HttpGet]
        [Route("MostraNome")]
        public Fornecedor GetFornecedorNome(string Nome)
        {
            Fornecedor item = repositorio.GetByNome(Nome);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpGet]
        [Route("MostraId")]
        public Fornecedor GetFornecedor(int id)
        {
            Fornecedor item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        [Route("Gravar")]
        public HttpResponseMessage PostFornecedor(Fornecedor item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Fornecedor>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.IDFornecedor });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        [HttpPut]
        [Route("Alterar")]
        public void PutFornecedor(int id, Fornecedor fornecedor)
        {
            fornecedor.IDFornecedor = id;
            if (!repositorio.Update(fornecedor))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("Apagar")]
        public void DeleteFornecedor(int id)
        {
            Fornecedor item = repositorio.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Remove(id);
        }
    }
}

