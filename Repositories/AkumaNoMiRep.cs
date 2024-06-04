using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class AkumaNoMiRep
    {
        private string Conn { get; set; }

        public AkumaNoMiRep()
        {
            Conn = "Data Source = 127.0.0.1; Initial Catalog=TB_AKUMANOMI; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        }

        public int InsertAkumaNoMi(AkumaNoMi a)
        {
            int status = 0;
            using (var dbConn = new SqlConnection(Conn))
            {
                dbConn.Open();
                status = dbConn.ExecuteScalar<int>(new AkumaNoMi().INSERT, a); //Retornara o primeiro elemento da primeira coluna encontrada
                dbConn.Close();
            }
            return status;
        }
    }
}