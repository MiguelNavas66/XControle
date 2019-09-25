using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetos.Dominio.Argumentos.Projeto
{
    public class ProjetoResponse
    {
        public int IDProjeto { get; set; }
        public string CodigoProj { get; set; }
        public string ProjetoNome { get; set; }
        public bool Finalizado { get; set; }
        public DateTime DtInicioProj { get; set; }
        public DateTime DtFimProj { get; set; }
        public float TotalProj { get; set; }
        public string Segmento { get; set; }
        public string Movimentacao { get; set; }
        public string Gerencia { get; set; }
        public string Historico { get; set; }
        public bool ProjetoIniciado { get; set; }
        public string NomeGP { get; set; }
    }
}
