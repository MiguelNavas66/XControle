using System;

namespace ControleDeProjetos.API.Models.Entities
{
    public class Movimentacao
    {
        public Guid IDMovimentacao { get; set; }
        public int IDProjeto { get; set; }
        public DateTime Periodo { get; set; }
        public float Valor { get; set; }
        public Enum.TipoMovimentacao TipoMovimentacao { get; set; }
    }
}