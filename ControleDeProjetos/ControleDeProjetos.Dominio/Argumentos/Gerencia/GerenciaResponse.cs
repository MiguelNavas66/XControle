using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetos.Dominio.Argumentos.Gerencia
{
    public class GerenciaResponse
    {
        public Guid IDGerencia { get; set; }
        public int IDProjeto { get; set; }
        public string Identificacao { get; set; }
        public string Responsavel { get; set; }
        public string Superintendencia { get; set; }
    }
}
