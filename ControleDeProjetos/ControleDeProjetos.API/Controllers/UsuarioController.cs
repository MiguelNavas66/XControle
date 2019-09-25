using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio.Argumentos.Usuario;
using ControleDeProjetos.Dominio.Extensao;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ControleDeProjetos.API.Controllers
{
    [RoutePrefix("Api/Usuario")]
    public class UsuarioController : ApiController
    {
      
        static readonly IUsuarioRepositorio repositorio = new UsuarioRepositorio();

        [HttpGet]
        [Route("Mostra")]
        public IEnumerable<UsuarioResponse> Mostra()
        {
            return repositorio.Mostra();
        }

        [HttpGet]
        [Route("MostraNome")]
        public Usuario MostraByID(int id)
        {
            Usuario item = repositorio.MostraByID(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        
        [HttpPost]
        [Route("Gravar")]
        public IHttpActionResult Gravar(Usuario request)
        {
            UsuarioResponse response = null;
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
        public void Altera(Guid id, Usuario usuario)
        {
            usuario.IDUsuario = id;
            if (!repositorio.Atualiza(usuario))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        [Route("Apagar")]
        public void Apaga(int id)
        {
            Usuario item = repositorio.MostraByID(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Apaga(id);
        }

        public Usuario Verifica(string email, string senha)
        {
            var pass = senha.ConvertToMD5();

            Usuario item = repositorio.Verifica(email, pass);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return item;
        }
    }
}
