using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio.Argumentos.Nota;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Models.Interfaces
{
    public interface INotaRepositorio
    {
        IEnumerable<NotaResponse> Mostra();
        Nota MostraByCodigo(string Codigo);
        NotaResponse Gravar(Nota item);
        void Apaga(string Codigo);
        bool Atualiza(Nota item);
    }
}
