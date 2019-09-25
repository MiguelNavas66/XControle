using ControleDeProjetos.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ControleDeProjetos.API.Models
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly EFDbContexto _db = new EFDbContexto();

        private List<Fornecedor> fornecedor = new List<Fornecedor>();
        private int _nextId = 1;

        public FornecedorRepositorio()
        {
            Add(new Fornecedor { IDFornecedor = 1, FornecedorNome = "Fornecedro_A" });
            Add(new Fornecedor { IDFornecedor = 2, FornecedorNome = "Fornecedro_B" });
            Add(new Fornecedor { IDFornecedor = 3, FornecedorNome = "Fornecedro_C" });
            Add(new Fornecedor { IDFornecedor = 4, FornecedorNome = "Fornecedro_D" });
            Add(new Fornecedor { IDFornecedor = 5, FornecedorNome = "Fornecedro_E" });
            Add(new Fornecedor { IDFornecedor = 6, FornecedorNome = "Fornecedro_F" });
        }

        public Fornecedor Add(Fornecedor item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IDFornecedor = _nextId++;
            fornecedor.Add(item);
            return item;
        }


        public IEnumerable<Fornecedor> GetAll()
        {
            var retorno = _db.Database.SqlQuery<Fornecedor>("GetFornecedores").ToList();
            return retorno;
            //return fornecedor;
        }

        public Fornecedor GetByNome(string Nome)
        {
            //var retorno = _db.Database.SqlQuery<Fornecedor>("GetFornecedoresByNome").FirstOrDefault();
            //return retorno;

            var retorno = _db.Database.SqlQuery<Fornecedor>("GetFornecedoresByNome @Nome"
                , new SqlParameter("Nome", Nome)).FirstOrDefault();
            if (retorno == null)
                retorno = new Fornecedor();

            return retorno;
        }

        public Fornecedor Get(int id)
        {
            return fornecedor.Find(p => p.IDFornecedor == id);
        }


        public void Remove(int id)
        {
            fornecedor.RemoveAll(p => p.IDFornecedor == id);
        }

        public bool Update(Fornecedor item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = fornecedor.FindIndex(p => p.IDFornecedor == item.IDFornecedor);

            if (index == -1)
            {
                return false;
            }
            fornecedor.RemoveAt(index);
            fornecedor.Add(item);
            return true;
        }

        
    }
}