using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.Dominio;
using ControleDeProjetos.Dominio.Argumentos.Nota;
using System;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Models.Repositories
{
    public class NotaRepositorio: INotaRepositorio
    {
        private readonly EFDbContexto _db = new EFDbContexto();

        public void Apaga(string Codigo)
        {
            throw new NotImplementedException();
        }

        public bool Atualiza(Nota item)
        {
            throw new NotImplementedException();
        }

        public NotaResponse Gravar(Nota item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NotaResponse> Mostra()
        {
            throw new NotImplementedException();
        }

        public Nota MostraByCodigo(string Codigo)
        {
            throw new NotImplementedException();
        }
    }
}