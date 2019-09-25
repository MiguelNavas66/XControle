using System;

namespace ControleDeProjetos.API.Models.Entities
{
    public class Reclassificacao
    {
        public Guid IDReclassificacao { get; set; }
        public Guid IDProjeto { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Ordem Ordem { get; set; }
        public string OIFaturamento { get; set; }
        public Nota Nota { get; set; }
        public float ValorReclassificado { get; set; }
        public TipoStatus TipoStatus { get; set; }
    }
}