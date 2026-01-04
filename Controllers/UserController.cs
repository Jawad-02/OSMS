using OSMS.Models;
using System.Text;
using System.Security.Cryptography;

namespace OSMS.Controllers
{
    public class UserController
    {

        public int RigesterUser(User user)
        {
            user.PasswordHash = HashPassword(user.PasswordHash);
            return user.Register();
        }

        
        public List<string> UserValidation(User user, string ConfirmPassword)
        {
            List<string> errors = new List<string>();
            

            if (string.IsNullOrWhiteSpace(user.UserName) || string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName) ||
                string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.PasswordHash) || string.IsNullOrWhiteSpace(ConfirmPassword))
            {

                errors.Add("All Fiels Are Required");
            }

            if (user.PasswordHash != ConfirmPassword)
            {
                errors.Add("The Passwords does not match");
            }

            if (!IsValidEmail(user.Email))
            {
                errors.Add("Invalid Email Address");
            }
            if(user.ExistUsernameOrEmail(user.UserName,user.Email))
            {
                errors.Add("Username or Email Is Already Exist");
            }

            return errors;

        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }

        public static string HashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();

        }

        public static bool VerifyPassword(string plainTextPassword, string hashedPassword)
        {
            string hashedPlainTextPassword = HashPassword(plainTextPassword);
            return hashedPlainTextPassword.Equals(hashedPassword);
        }
    }
}
