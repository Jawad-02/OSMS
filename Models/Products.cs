using OSMS.PublicClasses;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OSMS.Models
{
    public class Products : DatabaseConnection
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryID { get; set; }
        public string ImagePath { get; set; }

        // todo: implement navigation properties if needed


        // public Category Category { get; set; }
        // public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        // public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();

        public int AddProduct()
        {
            string sql = "INSERT INTO Products(Name, Description, Price, StockQuantity, CategoryID,ImagePath) VALUES(@name,@description,@price,@stockquantity,@catagoryid,@ImagePath)";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@name", this.Name);
            cmd.Parameters.AddWithValue("@description", this.Description);
            cmd.Parameters.AddWithValue("@price", this.Price);
            cmd.Parameters.AddWithValue("@stockquantity", this.StockQuantity);
            cmd.Parameters.AddWithValue("@catagoryid", this.CategoryID);
            cmd.Parameters.AddWithValue("@ImagePath", this.ImagePath);

            int res = cmd.ExecuteNonQuery();

            return res > 0 ? 1 : 0;
        }

        public int UpdateQuantity(int productID, int NewQuantity)
        {
            string sql = "UPDATE Products SET StockQuantity = @SQ Where ProductID = @PID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@SQ", NewQuantity);
            cmd.Parameters.AddWithValue("@PID", productID);
            int res = cmd.ExecuteNonQuery();

            return (res > 0) ? 1 : 0;
        }

        public int GetProudctsCount()
        {
            string quirey = "SELECT COUNT(*) FROM Products";
            SqlCommand cmd = new SqlCommand(quirey, con());
           
            int res = (int)cmd.ExecuteScalar();
            return res;
        }

        public int DeleteProduct(int  ProductID)
        {
            string sql = "DELETE FROM Products WHERE ProductID = @productID";
            SqlCommand cmd = new SqlCommand(sql,con());
            cmd.Parameters.AddWithValue("@productID",ProductID);

            int res = cmd.ExecuteNonQuery();

            return (res > 0) ? 1 : 0;
        }

        public int EditProduct()
        {
            string sql = "UPDATE Products SET Name = @name, Description = @description, Price=@price, StockQuantity=@stockquantity,CategoryID = @categoryid, ImagePath=@ImagePath WHERE ProductID=@productid";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@name",this.Name);
            cmd.Parameters.AddWithValue("@description",this.Description);
            cmd.Parameters.AddWithValue("@price", this.Price);
            cmd.Parameters.AddWithValue("@stockquantity", this.StockQuantity);
            cmd.Parameters.AddWithValue("@categoryid", this.CategoryID);
            cmd.Parameters.AddWithValue("@productid", this.ProductID);
            cmd.Parameters.AddWithValue("@ImagePath", this.ImagePath);

            int res = cmd.ExecuteNonQuery();
            return (res > 0) ? 1 : 0;

        }

        public List<Products> GetAllProducts() {
            string sql = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(sql,con() );

            var reader = cmd.ExecuteReader();
            var products = new List<Products>();
            while (reader.Read())
            {
                Products product = new Products {
                    ProductID = (int)reader["ProductID"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"],
                    Price = (decimal)reader["Price"],
                    StockQuantity = (int)reader["StockQuantity"],
                    CategoryID = (int)reader["CategoryID"],
                    ImagePath = (string)reader["ImagePath"]
                };
                products.Add(product);
            }
            return products;
        
        }

        public List<Products> GetAllProductsByCategoryID(int CategoryID)
        {
            string sql = "SELECT * FROM Products WHERE CategoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            var reader = cmd.ExecuteReader();
            var products = new List<Products>();
            while (reader.Read())
            {
                Products product = new Products
                {
                    ProductID = (int)reader["ProductID"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"],
                    Price = (decimal)reader["Price"],
                    StockQuantity = (int)reader["StockQuantity"],
                    CategoryID = (int)reader["CategoryID"],
                    ImagePath = (string)reader["ImagePath"]
                };
                products.Add(product);
            }
            return products;

        }

        public Products GetProduct(int productID)
        {
            string sql = "SELECT * FROM Products WHERE ProductID=@Productid";
            SqlCommand cmd = new SqlCommand (sql,con());
            cmd.Parameters.AddWithValue("@Productid",productID);

            var reader = cmd.ExecuteReader();
            Products product = null;
            if (reader.Read())
            {
                 product = new Products {
                    ProductID = (int)reader["ProductID"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"],
                    Price = (decimal)reader["Price"],
                    StockQuantity = (int)reader["StockQuantity"],
                    CategoryID = (int)reader["CategoryID"],
                     ImagePath = (string)reader["ImagePath"]
                 };
                return product;
            }
            return product;
            
        }

    }
}
