//using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class UserRep
    {
        private string Conn { get; set; }

        public UserRep()
        {
            Conn = "Data Source = 127.0.0.1; Initial Catalog=TB_AKUMANOMI; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        }

        public bool InsertUser(User u)
        {

            bool status = false;
            using (var dbConn = new SqlConnection(Conn))
            {
                dbConn.Open();
                SqlCommand cmd = new(new User().INSERT, dbConn);
                cmd.Parameters.Add(new SqlParameter("@USERNAME", u.UserName));
                cmd.Parameters.Add(new SqlParameter("@USERAGE", u.UserAge));
                cmd.Parameters.Add(new SqlParameter("@HASKINGHAKI", u.HasKingHaki));
                cmd.Parameters.Add(new SqlParameter("@AKUMANOMI_ID", u.AkumaNoMi.Id));
                //dbConn.Execute(new User().INSERT, u);
                cmd.ExecuteNonQuery();
                status = true;
                dbConn.Close();
            }
            return status;
        }
    }
}
