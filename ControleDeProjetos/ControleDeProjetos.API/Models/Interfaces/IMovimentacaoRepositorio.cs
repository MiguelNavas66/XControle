using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio.Argumentos.Movimentacao;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Models.Interfaces
{
    public interface IMovimentacaoRepositorio
    {
        IEnumerable<MovimentacaoResponse> Mostra();
        Movimentacao MostraByCodigo(string Codigo);
        MovimentacaoResponse Gravar(Movimentacao item);
        void Apaga(string Codigo);
        bool Atualiza(Movimentacao item);
    }
}