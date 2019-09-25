using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetos.Dominio.Argumentos.Ordem
{
    public class OrdemResponse
    {
        public Guid IDOrdem { get; set; }
        public int IDProjeto { get; set; }
        public string OrdemNumero { get; set; }
        public string TipoOrdem { get; set; }
        public float ValorOrdem { get; set; }
        public string Nota { get; set; }
    }
}
