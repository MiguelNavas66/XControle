using System;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Models.Entities
{
    public class Ordem
    {
        public Guid IDOrdem { get; set; }
        public int IDProjeto { get; set; }
        public string OrdemNumero { get; set; }
        public Enum.TipoOrdem TipoOrdem { get; set; }
        public float ValorOrdem { get; set; }
        public List<Nota> Nota { get; set; }
    }
}