using System.Collections.Generic;
using ControleDeProjetos.API.Models.Entities;
using ControleDeProjetos.API.Models.Interfaces;
using ControleDeProjetos.Dominio;
using ControleDeProjetos.Dominio.Argumentos.Projeto;

namespace ControleDeProjetos.API.Models.Repositories
{
    public class ProjetoRepositorio : IProjetoRepositorio
    {
        private readonly EFDbContexto _db = new EFDbContexto();

        public void Apaga(string Codigo)
        {
            throw new System.NotImplementedException();
        }

        public bool Atualiza(Projeto item)
        {
            throw new System.NotImplementedException();
        }

        public ProjetoResponse Gravar(Projeto item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProjetoResponse> Mostra()
        {
            throw new System.NotImplementedException();
        }

        public Projeto MostraByCodigo(string codigo)
        {
            throw new System.NotImplementedException();
        }

        
    }
}