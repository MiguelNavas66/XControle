using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio.Argumentos.Projeto;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Models.Interfaces
{
    public interface IProjetoRepositorio
    {
        IEnumerable<ProjetoResponse> Mostra();
        Projeto MostraByCodigo(string Codigo);
        ProjetoResponse Gravar(Projeto item);
        void Apaga(string Codigo);
        bool Atualiza(Projeto item);
        
    }
}
