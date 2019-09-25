using System;

namespace ControleDeProjetos.API.Models.Entities
{
    public class Gerencia
    {
        public Guid IDGerencia { get; set; }
        public int IDProjeto { get; set; }
        public string Identificacao { get; set; }
        public string Responsavel { get; set; }
        public string Superintendencia { get; set; }
    }
}