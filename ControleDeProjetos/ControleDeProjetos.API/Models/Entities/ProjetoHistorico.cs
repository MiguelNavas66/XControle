using System;

namespace ControleDeProjetos.API.Models.Entities
{
    public class ProjetoHistorico
    {
        public int IDProjHist { get; set; }
        public int IDProjeto { get; set; }
        public DateTime AprovadoAno { get; set; }
        public float AprovadoValor { get; set; }
        public DateTime RealizadoAno { get; set; }
        public float RealizadoValor { get; set; }
        public float TotalDispAtu { get; set; }
        public bool Alterado { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string MotivoAlteracao { get; set; }
        public DateTime DtInicioProj { get; set; }
        public DateTime DtFimProj { get; set; }
        public float TotalProj { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Usuario UsuarioLogado { get; set; }
        public TipoStatus TipoStatus { get; set; }
    }
}