using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace ProjetoModelo.Domain.Concrete
{
    public static class My
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);
    }
}
