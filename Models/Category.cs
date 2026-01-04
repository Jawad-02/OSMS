using OSMS.PublicClasses;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace OSMS.Models
{
    public class Category : DatabaseConnection
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }



        // Todo: implement the category methods after making ui for category management
        // Note: just uncomment the methods when you implement them

        //public int AddCategory(Category category)
        //{
        //    string sql = "INSERT INTO Categories(Name,Description) VALUES(@name,@des)";
        //    SqlCommand cmd = new SqlCommand(sql,con());
        //    cmd.Parameters.AddWithValue("@name",category.Name);
        //    cmd.Parameters.AddWithValue("@des",category.Description);
        //    int res = cmd.ExecuteNonQuery();
        //    return res > 0 ? 1 : 0;

        //}
        //public int DeleteCategory(int  categoryID)
        //{
        //    string sql = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
        //    SqlCommand cmd = new SqlCommand(sql, con());
        //    cmd.Parameters.AddWithValue("@CategoryID",categoryID);
        //    int res = cmd.ExecuteNonQuery();
        //    return res > 0 ? 1 : 0; 
        //}

        public int GetCategoryId(string name)
        {
            string sql = "SELECT * FROM Categories WHERE Name = @name";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@name",name);
            var reader = cmd.ExecuteReader();
            int res = -1;
            if (reader.Read())
            {
                res = (int)reader["CategoryID"];
            }
            
            return res;
        }

        public Category GetSingleCategory(int CategoryID)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            var reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                return new Category{
                    CategoryID = (int)reader["CategoryID"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"]
                };
            }

            return null;
        }

        //public List<Category> GetAllCategory()
        //{
        //    string sql = "SELECT * FORM Categories";
        //    SqlCommand cmd = new SqlCommand(sql,con()) ;
        //    var reader = cmd.ExecuteReader();
        //    var categories = new List<Category>();
        //    while(reader.Read())
        //    {
        //        Category category = new Category {
        //            CategoryID = (int)reader["CategoryID"],
        //            Name = (string)reader["Name"],
        //            Description = (string)reader["Description"]
        //        };
        //        categories.Add(category);
        //    }
        //    return categories;
        //}
        public int GetCategoryIdByCategoryName(string CategoryName)
        {
            string sql = "SELECT * FROM Categories WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand (sql,con());
            cmd.Parameters.AddWithValue("@Name", CategoryName);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader["CategoryID"];
            }
            else
            {
                return -1;
            }
        }

    }
}
