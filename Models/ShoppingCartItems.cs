using OSMS.PublicClasses;
using System.Data.SqlClient;


namespace OSMS.Models
{
    public class ShoppingCartItems : DatabaseConnection
    {
        public int ShoppingCartItemID { get; set; }

        public int UserID { get; set; }

        public int ProductID { get; set; }


        public int Quantity { get; set; }



        public int AddShoppingCartItem()
        {
            string sql = "INSERT INTO ShoppingCartItems(UserID,ProductID,Quantity) VALUES(@UserID,@ProductID,@Quantity)";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@UserID", this.UserID);
            cmd.Parameters.AddWithValue("@ProductID", this.ProductID);
            cmd.Parameters.AddWithValue("@Quantity", this.Quantity);
            int res = cmd.ExecuteNonQuery();
            return res > 0 ? 1 : 0;

        }

        public int DeleteShoppingCartItem(int ItemId)
        {
            string sql = "DELETE FROM ShoppingCartItems WHERE ShoppingCartItemID = @ID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@ID", ItemId);
            int res = cmd.ExecuteNonQuery();
            return res > 0 ? 1 : 0;
        }

        public int DeleteShoppingCartItemByUserID(int UserID)
        {
            string sql = "DELETE FROM ShoppingCartItems WHERE UserID = @ID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@ID", UserID);
            int res = cmd.ExecuteNonQuery();
            return res > 0 ? 1 : 0;
        }
        public List<ShoppingCartItems> GetAllShoppingCartItems(int userid)
        {
            string sql = "SELECT * FROM ShoppingCartItems WHERE UserID= @userid";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@userid", userid);
            var reader = cmd.ExecuteReader();
            var items = new List<ShoppingCartItems>();
            while (reader.Read())
            {
                ShoppingCartItems item = new ShoppingCartItems
                {
                    ShoppingCartItemID = (int)reader["ShoppingCartItemID"],
                    UserID = (int)reader["UserID"],
                    ProductID = (int)reader["ProductID"],
                    Quantity = (int)reader["Quantity"]
                };
                items.Add(item);
            }
            return items;
        }

    }
}
