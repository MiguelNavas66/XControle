using System;

namespace ControleDeProjetos.Dominio.Argumentos.Usuario
{
    public class UsuarioResponse
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }
    }
}
