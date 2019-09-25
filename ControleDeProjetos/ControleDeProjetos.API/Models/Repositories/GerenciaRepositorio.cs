using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.Dominio;
using ControleDeProjetos.Dominio.Argumentos.Gerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeProjetos.API.Models.Repositories
{
    public class GerenciaRepositorio : IGerenciaRepositorio
    {
        private readonly EFDbContexto _db = new EFDbContexto();

        public void Apaga(string Codigo)
        {
            throw new NotImplementedException();
        }

        public bool Atualiza(Gerencia item)
        {
            throw new NotImplementedException();
        }

        public GerenciaResponse Gravar(Gerencia item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GerenciaResponse> Mostra()
        {
            throw new NotImplementedException();
        }

        public Gerencia MostraByCodigo(string Codigo)
        {
            throw new NotImplementedException();
        }
    }
}