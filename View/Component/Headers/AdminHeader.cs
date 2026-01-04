using OSMS.PublicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSMS.View.Component.Headers
{
    public partial class AdminHeader : UserControl
    {
        public AdminHeader()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // go to The Dashboard Form

            SessionManager.ClearSession();
            Form frm = this.FindForm();
            frm.Hide();
            DashboardForm form = new DashboardForm();
            form.Show();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            Form frm = this.FindForm();
            frm.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // go to the Profile Form
            Form frm = this.FindForm();
            frm.Hide();
            ProfileForm form = new ProfileForm();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // go to The Cart Form
            Form frm = this.FindForm();
            frm.Hide();
            ShoppingCartForm form = new ShoppingCartForm();
            form.Show();
        }
    }
}
