using OSMS.Models;
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
    public partial class ProductDashboard : UserControl
    {
        public Products Products { get; set; }
        public ProductDashboard(Products product)
        {
            InitializeComponent();
            this.Products = product;
            string imagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", product.ImagePath);
            Image image = Image.FromFile(imagePath);
            pictureBox1.Image = image;
            label1.Text = product.Name;
            label2.Text = product.Price.ToString() + "$";
            label3.Text = "Stock: " + product.StockQuantity.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // go to the Edit Proudct
            EditProduct form = new EditProduct(Products);
            Form form1 = this.FindForm();
            form1.Close();
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // delete product
            int res = Products.DeleteProduct(Products.ProductID);
            if (res > 0)
            {
                MessageBox.Show("Product Deleted Successfully");
                DashboardForm form = new DashboardForm();
                Form form1 = this.FindForm();
                form1.Close();
                form.Show();
            }
        }
    }
}
