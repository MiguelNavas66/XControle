using ControleDeProjetos.API.Controllers;
using System;

namespace ControleDeProjetos.API.Models.Entities
{
    public class Usuario
    {
        public Guid IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Enum.TipoUsuario TipoUsuario { get; set; }

    }
}