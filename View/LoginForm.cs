using OSMS.Models;
using OSMS.Controllers;
using OSMS.PublicClasses;

namespace OSMS.View
{
    public partial class LoginForm : Form
    {
        Orders orders = new Orders();
        ShoppingCartItems shippingCartItems = new ShoppingCartItems();
        ShippingAddresses shippingaddresses = new ShippingAddresses();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.IconLeft = Properties.Resources.userbg_color;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.IconLeft = Properties.Resources.userbg_black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.IconLeft = Properties.Resources.passbg_color;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.IconLeft = Properties.Resources.passbg_black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            User user = new User{
                UserName = txtUsername.Text,
                PasswordHash = txtPassword.Text,
            };

            UserController control = new UserController();
            string hashedpassword = "";

            if(user.ExistUsernameOrEmail(user.UserName, user.UserName))
            {
                hashedpassword = user.GetHashedPassword(user.UserName);

                if (UserController.VerifyPassword(user.PasswordHash, hashedpassword))
                {
                    User CurrentUser = user.login(user.UserName, hashedpassword);
                    SessionManager.SetUserID(CurrentUser.UserID);
                    SessionManager.SetRole(CurrentUser.Role);
                    SessionManager.SetUser(CurrentUser);
                    SessionManager.SetOrders(orders.GetAllOrders(CurrentUser.UserID));
                    SessionManager.SetShoppingCartItems(shippingCartItems.GetAllShoppingCartItems(CurrentUser.UserID));
                    //SessionManager.SetShippingAddresses(shippingaddresses.GetAllAdressesByUserID(CurrentUser.UserID));
                    var addrs = shippingaddresses.GetAllAdressesByUserID(CurrentUser.UserID);
                    SessionManager.SetShippingAddresses(addrs);

                    MessageBox.Show("Login Successfully");
                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
                }else
                {
                    MessageBox.Show("Wrong Passowrd");
                }
            }else
            {
                MessageBox.Show("Wrong Username");
            }
            

            
        }
    }
}
