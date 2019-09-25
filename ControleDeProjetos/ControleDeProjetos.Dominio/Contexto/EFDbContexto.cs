using System.Data.Entity;

namespace ControleDeProjetos.Dominio
{
    public class EFDbContexto : DbContext
    {
        public EFDbContexto()
            : base("ConnectionProjetos")
        {
            var ensureDLLIsCopied =
               System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

    }
}
