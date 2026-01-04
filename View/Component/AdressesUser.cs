using OSMS.Models;
using OSMS.PublicClasses;

namespace OSMS.View.Component
{
    public partial class AdressesUser : UserControl
    {
        ShippingAddresses shippingAddresses = new ShippingAddresses();

        public AdressesUser(ShippingAddresses shippingAddresses)
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
            // this.AutoSize = true;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int res = this.shippingAddresses.DeleteAdress(shippingAddresses.AddressID);
            if(res > 0 )
            {
                MessageBox.Show("Address Removed Successfully if you still see it please refresh the page");
                SessionManager.SetShippingAddresses(shippingAddresses.GetAllAdressesByUserID(SessionManager.User.UserID));
            }
        }
    }
}
