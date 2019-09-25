using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio.Argumentos.Usuario;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Controllers
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<UsuarioResponse> Mostra();
        Usuario MostraByID(int id);
        UsuarioResponse Gravar(Usuario item);
        void Apaga(int id);
        bool Atualiza(Usuario item);
        Usuario Verifica(string email, string senha);
    }
}