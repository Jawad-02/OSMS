using OSMS.Models;

namespace OSMS.View.Component
{
    public partial class UsersDashboard : UserControl
    {
        User User { get; set; }
        public UsersDashboard(User user)
        {
            InitializeComponent();
            this.User = user;
            label1.Text = user.UserName;
            label2.Text = user.Role;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // deleteind user
            int res = User.DeleteUser(User.UserID);
            if (res > 0)
            {
                MessageBox.Show("user deleted Successfully");
                Form f = this.FindForm();
                DashboardForm form = new DashboardForm();
                f.Close();
                form.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int res = User.MakeAdmin(User.UserID);
            if (res > 0)
            {
                MessageBox.Show("user become an admin Successfully");
                Form f = this.FindForm();
                DashboardForm form = new DashboardForm();
                f.Close();
                form.Show();
            }
        }
    }
}
