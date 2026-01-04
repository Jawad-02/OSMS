using OSMS.Models;
using OSMS.PublicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSMS.View.Component
{
    public partial class CartView : UserControl
    {
        public CartView(ShoppingCartItems item)
        {
            InitializeComponent();
            this.AutoSize = true;
            Products products = new Products();
            products = products.GetProduct(item.ProductID);
            string imagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", products.ImagePath);
            Image image = Image.FromFile(imagePath);
            pictureBox1.Image = image;
            label1.Text = "Name: " + products.Name;
            label3.Text = "Quantity: " + item.Quantity.ToString();
            label4.Text = "Total: " + (item.Quantity * products.Price).ToString() + "$";
            SessionManager.IncreaseTotalAmount(item.Quantity * products.Price);
        }
    }
}
