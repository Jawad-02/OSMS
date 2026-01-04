
using OSMS.Models;
using OSMS.PublicClasses;
using OSMS.Controllers;

namespace OSMS.View.Component
{
    public partial class ProfileUser : UserControl
    {
        public ProfileUser()
        {
            InitializeComponent();
            label1.Text = "Username: " + SessionManager.User.UserName;
            label2.Text = "Firstname: " + SessionManager.User.FirstName;
            label3.Text = "Lastname: " + SessionManager.User.LastName;
            label4.Text = "Email: " + SessionManager.User.Email;
            label5.Text = "Role: " + SessionManager.User.Role;
            this.AutoSize = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            User user = new User();
            int res = user.ChangeUsername(SessionManager.User.UserID, guna2TextBox1.Text.ToString());
            if (res < 0)
            {
                MessageBox.Show("This Username Is Already Token");

            }
            else
            {
                MessageBox.Show("Username Updated Successfully");
                SessionManager.SetUser(user.GetUser(user.UserID));
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            User user = new User();
            int res = user.ChangePassword(SessionManager.User.UserID, UserController.HashPassword(guna2TextBox2.Text.ToString()));
            if (res < 0)
            {
                MessageBox.Show("Can Not Change The Password");

            }
            else
            {
                MessageBox.Show("Password Updated Successfully");
            }

        }

    }
}

