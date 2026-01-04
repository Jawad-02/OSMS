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
    public partial class CatrItem : UserControl
    {
        ShoppingCartItems cartItems = new ShoppingCartItems();

        public CatrItem(ShoppingCartItems item)
        {
            InitializeComponent();
            this.AutoSize = true;
            this.cartItems = item;
            Products products = new Products();
            products = products.GetProduct(item.ProductID);
            string imagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", products.ImagePath);
            Image image = Image.FromFile(imagePath);
            pictureBox1.Image = image;
            label1.Text = "Name: " + products.Name;
            label2.Text = "Price: " + products.Price.ToString() + "$";
            label3.Text = "Quantity: " + item.Quantity.ToString();
            label4.Text = "Total: " + (item.Quantity * products.Price).ToString() + "$";

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int res = cartItems.DeleteShoppingCartItem(cartItems.ShoppingCartItemID);
            if (res > 0)
            {
                MessageBox.Show("Item Removed Successfully");
                SessionManager.SetShoppingCartItems(cartItems.GetAllShoppingCartItems(SessionManager.User.UserID));
                Form f = this.FindForm();
                f.Close();
                ShoppingCartForm form = new ShoppingCartForm(); 
                form.Show();
            }else
            {
                MessageBox.Show("Could not delete Item");
            }
        }
    }
}
