using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.Dominio.Argumentos.Gerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProjetos.API.Models.Interfaces
{
    public interface IGerenciaRepositorio
    {
        IEnumerable<GerenciaResponse> Mostra();
        Gerencia MostraByCodigo(string Codigo);
        GerenciaResponse Gravar(Gerencia item);
        void Apaga(string Codigo);
        bool Atualiza(Gerencia item);
    }
}
