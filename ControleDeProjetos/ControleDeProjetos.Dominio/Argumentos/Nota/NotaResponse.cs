using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetos.Dominio.Argumentos.Nota
{
    public class NotaResponse
    {
        public Guid IDNota { get; set; }
        public int IDOrdem { get; set; }
        public string NotaNumero { get; set; }
        public string PedidoNumero { get; set; }
        public DateTime DataReferencia { get; set; }
        public float Valor { get; set; }
        public string Fornecedor { get; set; }
    }
}
