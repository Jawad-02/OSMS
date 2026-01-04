using OSMS.Models;
using OSMS.Controllers;

namespace OSMS.View
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                UserName = txtUsername.Text,
                Email = txtEmail.Text,
                PasswordHash = txtPassword.Text,
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text
            };
            UserController Contor = new UserController();
            List<string> errors = Contor.UserValidation(newUser, txtConfirmpassword.Text);
            if (errors.Count != 0)
            {
                string errorMsg = "";
                foreach (string error in errors)
                {
                    errorMsg += error + "\n";
                }
                MessageBox.Show("Errors:" + errorMsg);

            }
            else
            {
                int res = Contor.RigesterUser(newUser);
                if (res > 0)
                {
                    MessageBox.Show("Registered Successfully Please Login");

                }
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.IconLeft = Properties.Resources.userbg_color;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.IconLeft = Properties.Resources.userbg_black;
        }

        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            txtFirstname.IconLeft = Properties.Resources.userbg_color;
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            txtFirstname.IconLeft = Properties.Resources.userbg_black;
        }

        private void txtLastname_Enter(object sender, EventArgs e)
        {
            txtLastname.IconLeft = (Properties.Resources.userbg_color);
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            txtLastname.IconLeft = (Properties.Resources.userbg_black);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.IconLeft = Properties.Resources.userbg_color;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.IconLeft = Properties.Resources.userbg_black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.IconLeft = Properties.Resources.userbg_color;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.IconLeft = (Properties.Resources.userbg_black);
        }

        private void txtConfirmpassword_Enter(object sender, EventArgs e)
        {
            txtConfirmpassword.IconLeft = Properties.Resources.userbg_color;
        }

        private void txtConfirmpassword_Leave(object sender, EventArgs e)
        {
            txtConfirmpassword.IconLeft = (Properties.Resources.userbg_black);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
