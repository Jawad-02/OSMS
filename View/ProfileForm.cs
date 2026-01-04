using OSMS.Models;
using OSMS.PublicClasses;
using OSMS.View.Component;
using OSMS.View.Component.Headers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSMS.View
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            label1.Text = "Welcome " + SessionManager.User.UserName;
            // this.Profile_Page.Click += new System.EventHandler(this.HomePage_Click);
        }

        private void LoadPageContent(UserControl Page)
        {

            flowLayoutPanel1.Visible = true;
            Page.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(Page);
            Page.BringToFront();

        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Orders orders in SessionManager.Orders)
            {
                OrderUser page = new OrderUser(orders);
                flowLayoutPanel1.Controls.Add(page);
                page.BringToFront();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (ShippingAddresses Address in SessionManager.ShippingAddresses)
            {
                AdressesUser page = new AdressesUser(Address);
                flowLayoutPanel1.Controls.Add(page);
                page.BringToFront();
            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            AddAddressForm form = new AddAddressForm();
            form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void rofile_Page_Click(object sender, EventArgs e)
        {
            

             flowLayoutPanel1.Visible = true;
             ProfileUser page = new ProfileUser();
             LoadPageContent(page);

            
        }
    }
}
