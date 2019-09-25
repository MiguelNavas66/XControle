using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetos.Dominio.Argumentos.Movimentacao
{
    public class MovimentacaoResponse
    {
        public Guid IDMovimentacao { get; set; }
        public int IDProjeto { get; set; }
        public DateTime Periodo { get; set; }
        public float Valor { get; set; }
        public string TipoMovimentacao { get; set; }
    }
}
