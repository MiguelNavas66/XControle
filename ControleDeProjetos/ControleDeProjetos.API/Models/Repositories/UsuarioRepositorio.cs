using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio;
using ControleDeProjetos.Dominio.Argumentos.Usuario;
using ControleDeProjetos.Dominio.Extensao;

namespace ControleDeProjetos.API.Controllers
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly EFDbContexto _db = new EFDbContexto();

        public UsuarioResponse Gravar(Usuario item)
        {
            var retorno = _db.Database.SqlQuery<UsuarioResponse>("GravaUsuario @Nome,@Email,@Senha,@TipoUsuario"
                , new SqlParameter("Nome", item.Nome)
                , new SqlParameter("Email", item.Email)
                , new SqlParameter("Senha", item.Senha.ConvertToMD5())
                , new SqlParameter("TipoUsuario", item.TipoUsuario.ToString())
                ).FirstOrDefault();
            if (retorno == null)
                retorno = new UsuarioResponse();

            return retorno;

        }

        public void Apaga(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Atualiza(Usuario item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UsuarioResponse> Mostra()
        {
            var retorno = _db.Database.SqlQuery<UsuarioResponse>("GetUsuarios").ToList();
            return retorno;
        }

        public Usuario MostraByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Verifica(string email, string senha)
        {
            var pass = senha.ConvertToMD5();

            var retorno = _db.Database.SqlQuery<Usuario>("GetUsuarioByLogin @email,@pass"
                , new SqlParameter("email", email)
                , new SqlParameter("senha", pass)
                ).FirstOrDefault();
            if (retorno == null)
                retorno = new Usuario();

            return retorno;
        }
    }
}