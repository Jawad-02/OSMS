using OSMS.Models;
using OSMS.Controllers;
using System.Data.SqlClient;

namespace OSMS.PublicClasses
{
    public class DatabaseInitializer : DatabaseConnection
    {
        public void SeedCategories()
        {
            using (var conn = con())
            {
                string checkSql = "SELECT COUNT(*) FROM Categories";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);

                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string insertSql =
                        "INSERT INTO Categories (Name, Description) VALUES " +
                        "('Men', 'Men clothing')," +
                        "('Women', 'Women clothing')," +
                        "('Unisex', 'Unisex clothing');";

                    SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        public void SeedAdminUser()
        {
            using (var conn = con())
            {
                string checkSql = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);

                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    User admin = new User
                    {
                        UserName = "admin",
                        PasswordHash = "admin123",   // will be hashed by controller
                        Email = "admin@store.com",
                        Role = "Admin",
                        FirstName = "System",
                        LastName = "Administrator"
                    };

                    UserController controller = new UserController();
                    controller.RigesterUser(admin);
                }
            }
        }

        public void Initialize()
        {
            SeedCategories();
            SeedAdminUser();
        }
    }
}
