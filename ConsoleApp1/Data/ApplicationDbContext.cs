using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Netflix_Projekt_2sem.Data
{

    namespace Netflix_Projekt_2sem
    {
        public class Database
        {
            private readonly string connectionString =
                "Server=localhost;Database=mssql17.unoeuro.com;User Id=sa;Password=6GgD3AdRe59mapzhHxw4;TrustServerCertificate=True;";

            public SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}