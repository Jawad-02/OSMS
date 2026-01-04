using OSMS.PublicClasses;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace OSMS.Models
{
    public class OrderItems : DatabaseConnection
    {
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        
        public int Quantity { get; set; }


        public int AddOrderItem(OrderItems newitem)
        {
            string sql = "INSERT INTO OrderItems(OrderID, ProductID,Quantity) VALUES(@OrderID, @ProductID,@Quantity)";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@OrderID", newitem.OrderID);
            cmd.Parameters.AddWithValue("@ProductID", newitem.ProductID);
            cmd.Parameters.AddWithValue("@Quantity", newitem.Quantity);
            int res = cmd.ExecuteNonQuery();

            return res > 0 ? 1 : 0;
        }

        public int DeleteOrderItem(int OrderItemID)
        {
            string sql = "DELETE FROM OrderItems WHERE OrderItemID = @OrderItemID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@OrderItemID", OrderItemID);

            int res = cmd.ExecuteNonQuery();

            return (res > 0) ? 1 : 0;
        }

        public List<(string ProductName, int Quantity)> GetOrderItemsWithProduct(int orderID)
        {
            string sql = @"SELECT p.Name, oi.Quantity 
                   FROM OrderItems oi
                   JOIN Products p ON oi.ProductID = p.ProductID
                   WHERE oi.OrderID = @OID";

            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@OID", orderID);

            var list = new List<(string, int)>();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add((reader.GetString(0), reader.GetInt32(1)));

            return list;
        }

    }
}
