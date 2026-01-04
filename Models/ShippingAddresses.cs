using OSMS.PublicClasses;
using System.Data.SqlClient;


namespace OSMS.Models
{
    public class ShippingAddresses : DatabaseConnection
    {
        public int AddressID { get; set; }
        public int UserID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public int AddAddress()
        {
            string sql = "INSERT INTO ShippingAddresses(UserID,AddressLine1,AddressLine2,City,State,ZipCode,Country) VALUES(@UserID,@AddressLine1,@AddressLine2,@City,@State,@ZipCode,@Country)";
            SqlCommand cmd = new SqlCommand(sql,con());
            cmd.Parameters.AddWithValue("@UserID", this.UserID);
            cmd.Parameters.AddWithValue("@AddressLine1", this.AddressLine1);
            cmd.Parameters.AddWithValue("@AddressLine2", this.AddressLine2);
            cmd.Parameters.AddWithValue("@City", this.City);
            cmd.Parameters.AddWithValue("@State", this.State);
            cmd.Parameters.AddWithValue("@ZipCode", this.ZipCode);
            cmd.Parameters.AddWithValue("@Country", this.Country);
            int res = cmd.ExecuteNonQuery();

            return res > 0 ? 1 : 0;
        }

        public int DeleteAdress(int addressID)
        {
            string sql = "DELETE FROM ShippingAddresses WHERE AddressID = @AddressID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@AddressID", addressID);
            int res = cmd.ExecuteNonQuery();

            return res > 0 ? 1 : 0;
        }

        public List<ShippingAddresses> GetAllAdressesByUserID(int UserID)
        {
            string sql = "SELECT * FROM ShippingAddresses WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@UserID", UserID);
            var reader = cmd.ExecuteReader();
            List<ShippingAddresses> shippingAddresses = new List<ShippingAddresses>();
            while (reader.Read())
            {
                ShippingAddresses shippingAddress = new ShippingAddresses{
                    AddressID = (int)reader["AddressID"],
                    UserID = (int)reader["UserID"],
                    AddressLine1 = (string)reader["AddressLine1"],
                    AddressLine2 = (string)reader["AddressLine2"],
                    City = (string)reader["City"],
                    State = (string)reader["State"],
                    ZipCode = (string)reader["ZipCode"],
                    Country = (string)reader["Country"]
                }; 
                shippingAddresses.Add(shippingAddress);
            }
            return shippingAddresses;
        }
    }
}
