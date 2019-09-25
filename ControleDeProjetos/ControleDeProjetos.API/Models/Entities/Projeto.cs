using System;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Models.Entities
{
    public class Projeto
    {
        public Guid IDProjeto { get; set; }
        public string CodigoProj { get; set; }
        public string ProjetoNome { get; set; }
        public bool Finalizado { get; set; }
        public DateTime DtInicioProj { get; set; }
        public DateTime DtFimProj { get; set; }
        public float TotalProj { get; set; }
        public List<Segmento> Segmento { get; set; }
        public List<Movimentacao> Movimentacao { get; set; }
        public List<Gerencia> Gerencia { get; set; }
        public List<ProjetoHistorico> Historico { get; set; }
        public bool ProjetoIniciado { get; set; }
        public string NomeGP { get; set; }
    }
}