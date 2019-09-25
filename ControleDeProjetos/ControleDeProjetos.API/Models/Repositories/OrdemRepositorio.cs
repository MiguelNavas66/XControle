using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.Dominio;
using ControleDeProjetos.Dominio.Argumentos.Ordem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeProjetos.API.Models.Repositories
{
    public class OrdemRepositorio : IOrdemRepositorio
    {
        private readonly EFDbContexto _db = new EFDbContexto();

        public void Apaga(string Codigo)
        {
            throw new NotImplementedException();
        }

        public bool Atualiza(Ordem item)
        {
            throw new NotImplementedException();
        }

        public OrdemResponse Gravar(Ordem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrdemResponse> Mostra()
        {
            throw new NotImplementedException();
        }

        public Ordem MostraByCodigo(string Codigo)
        {
            throw new NotImplementedException();
        }
    }
}