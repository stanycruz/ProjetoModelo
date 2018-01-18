using System.Configuration;

namespace ProjetoModelo.Domain.Concrete
{
    public class ConnectionString
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["ProjetoModeloConnectionString"].ConnectionString;
    }
}
