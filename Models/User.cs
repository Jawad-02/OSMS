using Microsoft.VisualBasic.ApplicationServices;
using OSMS.PublicClasses;
using System.Data.SqlClient;

namespace OSMS.Models
{
    public class User : DatabaseConnection
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } = "User";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public User()
        {

        }

        public int GetUsersCount()
        {
            string quirey = "SELECT COUNT(*) FROM Users";
            SqlCommand cmd = new SqlCommand(quirey, con());

            int res = (int)cmd.ExecuteScalar();
            return res;
        }
        public bool ExistUsernameOrEmail(string username, string email){

            string quirey = "SELECT COUNT(*) FROM Users WHERE Username = @UNAME OR Email = @EMAIL";
            SqlCommand cmd = new SqlCommand(quirey, con());
            cmd.Parameters.AddWithValue("@UNAME", username);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            int res = (int)cmd.ExecuteScalar();
            return res > 0;
        }
        public int Register(){

            if (!ExistUsernameOrEmail(this.UserName, this.Email))
            {
                string quirey = "INSERT INTO Users(Username, PasswordHash, Email, Role, FirstName, LastName) VALUES (@UNAME,@PASSWORD,@EMAIL,@ROLE,@FNAME,@LNAME)";
                SqlCommand cmd = new SqlCommand(quirey, con());
                cmd.Parameters.AddWithValue("@UNAME", this.UserName);
                cmd.Parameters.AddWithValue("@PASSWORD", this.PasswordHash);
                cmd.Parameters.AddWithValue("@EMAIL", this.Email);
                cmd.Parameters.AddWithValue("@ROLE", this.Role);
                cmd.Parameters.AddWithValue("@FNAME", this.FirstName);
                cmd.Parameters.AddWithValue("@LNAME", this.LastName);
                int res = cmd.ExecuteNonQuery();
                return res > 0 ? 1 : 0;
            }
            return -1; // error code means username or email is already exist
        }

        public User login(string Username, string password){

            string quirey = "SELECT * FROM USERS WHERE UserName = @Uname AND PasswordHash = @PASSWORD";
            SqlCommand cmd = new SqlCommand(quirey, con());
            cmd.Parameters.AddWithValue("@Uname", Username);
            cmd.Parameters.AddWithValue ("@PASSWORD", password);
            var reader = cmd.ExecuteReader();
            int res = -1;
            if (reader.Read())
            {
                User current = new User{
                    UserID = (int)reader["UserID"],
                    UserName = (string)reader["Username"],
                    PasswordHash = (string)reader["PasswordHash"],
                    Email = (string)reader["Email"],
                    Role = (string)reader["Role"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],

                };

                return current;
            }
            return null;
        }

        public string GetHashedPassword(string Username)
        {
            string sql = "SELECT * FROM Users WHERE Username = @username";
            SqlCommand cmd = new SqlCommand (sql, con());
            cmd.Parameters.AddWithValue("@username", Username);
            var reader = cmd.ExecuteReader();   
            if(reader.Read())
            {
                return (string)reader["PasswordHash"];
            }
            else
            {
                return "Password Does not Exist";
            }
        }

        public int ChangePassword(int userID,string password){   
            
            string quirey = "UPDATE Users SET PasswordHash = @PASSWORD WHERE UserID = @UID";
            SqlCommand cmd = new SqlCommand(quirey, con());
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.Parameters.AddWithValue("@UID", userID);
            int res = cmd.ExecuteNonQuery();
            return res > 0 ? 1 : 0;
        }

        public int ChangeUsername(int UserID, string newUsername) {

            if (!ExistUsernameOrEmail(newUsername, newUsername))
            {
                string quirey = "UPDATE Users SET Username = @UNAME WHERE UserID = @UID";
                SqlCommand cmd = new SqlCommand(quirey, con());
                cmd.Parameters.AddWithValue("@UNAME", newUsername);
                cmd.Parameters.AddWithValue("@UID", UserID);
                int res = cmd.ExecuteNonQuery();
                return res > 0 ? 1 : 0;
            }
            return -1; // error code means username or email is already exist
        }

        public int MakeAdmin(int userID){

            string quirey = "UPDATE Users SET Role = @Role WHERE UserID = @UID";
            SqlCommand cmd = new SqlCommand(quirey, con());
            cmd.Parameters.AddWithValue("@Role", "Admin");
            cmd.Parameters.AddWithValue("@UID", userID);
            int res = cmd.ExecuteNonQuery();
            return res > 0 ? 1 : 0;
        }
        public int DeleteUser(int userID){
            string quirey = "DELETE FROM Users WHERE UserID = @UID";
            SqlCommand cmd = new SqlCommand(quirey, con());
            cmd.Parameters.AddWithValue("@UID", userID);
            int res = cmd.ExecuteNonQuery();
            return res > 0 ? 1 : 0;
        }
        public List<User> GetUsers(){

            List<User> users = new List<User>();
            string quirey = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(quirey, con());
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User {
                    UserID = (int)reader["UserID"],
                    UserName = (string)reader["Username"],
                    PasswordHash = (string)reader["PasswordHash"],
                    Email = (string)reader["Email"],
                    Role = (string)reader["Role"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                };
                users.Add(user);
            }
            return users;
        }
        public User GetUser(int userID)
        {
            string sql = "Select * from Users Where UserID = @UserID";
            SqlCommand cmd = new SqlCommand(sql, con());
            cmd.Parameters.AddWithValue("@UserID", userID);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    UserID = (int)reader["UserID"],
                    UserName = (string)reader["Username"],
                    PasswordHash = (string)reader["PasswordHash"],
                    Email = (string)reader["Email"],
                    Role = (string)reader["Role"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                };
            }
            return null;
        }

    }
}
