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

namespace OSMS.View.Component
{
    public partial class UserAdresses : UserControl
    {
        ShippingAddresses shippingAddresses = new ShippingAddresses();
        public UserAdresses(ShippingAddresses shippingAddresses)
        {
            InitializeComponent();
            this.shippingAddresses = shippingAddresses;
            label1.Text = "AddressID: " + shippingAddresses.AddressID.ToString();
            label2.Text = "AddressLine1: " + shippingAddresses.AddressLine1.ToString();
            label3.Text = "AddressLine2: " + shippingAddresses.AddressLine2.ToString();
            label4.Text = "City: " + shippingAddresses.City.ToString();
            label5.Text = "State: " + shippingAddresses.State.ToString();
            label6.Text = "ZipCode: " + shippingAddresses.ZipCode.ToString();
            label7.Text = "Country: " + shippingAddresses.Country.ToString();
            this.AutoSize = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SessionManager.SetSelectedAddress(shippingAddresses);
            MessageBox.Show("Address Selected Successfully");
        }
    }
}
