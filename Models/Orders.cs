using OSMS.PublicClasses;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace OSMS.Models
{
    public class Orders : DatabaseConnection
    {
        public int OrderID { get; set; }

        public int UserID { get; set; }

        
        public DateTime OrderDate { get; set; } = DateTime.Now;

        
        public decimal TotalAmount { get; set; }

        
        public string OrderStatus { get; set; } = "Pending";

        
        public User User { get; set; }
        

        public int GetOrderCount()
        {
            string quirey = "SELECT COUNT(*) FROM Orders";
            SqlCommand cmd = new SqlCommand(quirey, con());

            int res = (int)cmd.ExecuteScalar();
            return res;
        }
        public int AddOrder()
        {
            string sql = @"INSERT INTO Orders (UserID, OrderDate, TotalAmount, OrderStatus)
                   OUTPUT INSERTED.OrderID
                   VALUES (@UserID, @OrderDate, @TotalAmount, @OrderStatus)";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@UserID", this.UserID);
            cmd.Parameters.AddWithValue("@OrderDate",this.OrderDate);
            cmd.Parameters.AddWithValue("@TotalAmount",this.TotalAmount);
            cmd.Parameters.AddWithValue("@OrderStatus",this.OrderStatus);


            return (int)cmd.ExecuteScalar();
        }
        public int CangeStatus(int orderId,string Status)
        {
            string sql = "UPDATE Orders SET OrderStatus = @orderStatus WHERE OrderID = @orderid";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@orderStatus", Status);
            cmd.Parameters.AddWithValue("@orderid", orderId);

            int res = cmd.ExecuteNonQuery();

            return res > 0 ? 1 : 0;
        }


        public List<Orders> GetAllOrders(int UserID)
        {
            string sql = "SELECT * FROM Orders WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(sql,con());
            cmd.Parameters.AddWithValue("@UserID", UserID);
            List<Orders> orders = new List<Orders>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Orders order = new Orders {
                    OrderID = (int)reader["OrderID"],
                    UserID = (int)reader["UserID"],
                    OrderDate = (DateTime)reader["OrderDate"],
                    TotalAmount = (decimal)reader["TotalAmount"],
                    OrderStatus = (string)reader["OrderStatus"]
                };
                orders.Add(order);
            }
            return orders;
        }

        public List<Orders> GetAllOrders()
        {
            string sql = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(sql, con());
            List<Orders> orders = new List<Orders>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Orders order = new Orders
                {
                    OrderID = (int)reader["OrderID"],
                    UserID = (int)reader["UserID"],
                    OrderDate = (DateTime)reader["OrderDate"],
                    TotalAmount = (decimal)reader["TotalAmount"],
                    OrderStatus = (string)reader["OrderStatus"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
