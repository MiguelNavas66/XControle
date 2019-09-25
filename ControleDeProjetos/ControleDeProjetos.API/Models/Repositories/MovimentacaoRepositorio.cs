using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.Dominio;
using ControleDeProjetos.Dominio.Argumentos.Movimentacao;
using System;
using System.Collections.Generic;

namespace ControleDeProjetos.API.Models.Repositories
{
    public class MovimentacaoRepositorio : IMovimentacaoRepositorio
    {
        private readonly EFDbContexto _db = new EFDbContexto();

        public void Apaga(string Codigo)
        {
            throw new NotImplementedException();
        }

        public bool Atualiza(Movimentacao item)
        {
            throw new NotImplementedException();
        }

        public MovimentacaoResponse Gravar(Movimentacao item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovimentacaoResponse> Mostra()
        {
            throw new NotImplementedException();
        }

        public Movimentacao MostraByCodigo(string Codigo)
        {
            throw new NotImplementedException();
        }
    }
}