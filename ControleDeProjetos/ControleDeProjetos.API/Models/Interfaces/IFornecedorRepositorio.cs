using System.Collections.Generic;

namespace ControleDeProjetos.API.Models
{
    public interface IFornecedorRepositorio
    {
        IEnumerable<Fornecedor> GetAll();
        Fornecedor GetByNome(string Nome);
        Fornecedor Get(int id);
        Fornecedor Add(Fornecedor item);
        void Remove(int id);
        bool Update(Fornecedor item);
    }
}
