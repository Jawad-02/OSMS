using System.Data.SqlClient;

namespace OSMS.PublicClasses
{
    
    public class DatabaseConnection
    {
        private string ConnectionString = "Data Source=DESKTOP-0FDD8NU\\JAWAD;Initial Catalog=OnlineStoreDB;Integrated Security=True;";

        protected SqlConnection con()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }

            return conn;
        }
    }
}
