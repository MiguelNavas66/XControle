using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio.Argumentos.Ordem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetos.API.Models.Interfaces
{
    public interface IOrdemRepositorio
    {
        IEnumerable<OrdemResponse> Mostra();
        Ordem MostraByCodigo(string Codigo);
        OrdemResponse Gravar(Ordem item);
        void Apaga(string Codigo);
        bool Atualiza(Ordem item);
    }
}
