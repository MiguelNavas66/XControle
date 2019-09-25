using System;

namespace ControleDeProjetos.API.Models.Entities
{
    public class Nota
    {
        public Guid IDNota { get; set; }
        public int IDOrdem { get; set; }
        public string NotaNumero { get; set; }
        public string PedidoNumero { get; set; }
        public DateTime DataReferencia { get; set; }
        public float Valor { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}