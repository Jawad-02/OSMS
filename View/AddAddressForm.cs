using Microsoft.VisualBasic.ApplicationServices;
using OSMS.Models;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OSMS.View
{
    public partial class AddAddressForm : Form
    {
        public AddAddressForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ShippingAddresses shippingAddresses = new ShippingAddresses
            {
                UserID = SessionManager.User.UserID,
                AddressLine1 = guna2TextBox1.Text,
                AddressLine2 = guna2TextBox2.Text,
                City = guna2TextBox3.Text,
                State = guna2TextBox4.Text,
                ZipCode = guna2TextBox5.Text,
                Country = guna2TextBox6.Text,
            };
            if (string.IsNullOrWhiteSpace(shippingAddresses.AddressLine1) || string.IsNullOrWhiteSpace(shippingAddresses.AddressLine2) || string.IsNullOrWhiteSpace(shippingAddresses.City) ||
            string.IsNullOrWhiteSpace(shippingAddresses.State) || string.IsNullOrWhiteSpace(shippingAddresses.ZipCode) || string.IsNullOrWhiteSpace(shippingAddresses.Country))
            {

                MessageBox.Show("All Fields are Required");
            }
            else
            {
                int res = shippingAddresses.AddAddress();
                if (res > 0)
                {
                    MessageBox.Show("Address Addes Sucessfully");
                    SessionManager.SetShippingAddresses(shippingAddresses.GetAllAdressesByUserID(SessionManager.User.UserID));
                    this.Close();
                    ProfileForm profileForm = new ProfileForm();
                    profileForm.Show();
                }
            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }
    }
}
