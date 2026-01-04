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

namespace OSMS.View
{
    public partial class EditProduct : Form
    {

        public Products pro = new Products();
        private string initialImagePath;
        private string imagePath;

        public EditProduct(Products products)
        {
            InitializeComponent();

            // Store the initial image path
            initialImagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", products.ImagePath);
            imagePath = products.ImagePath;
            pictureBox1.ImageLocation = initialImagePath;
            pro = products;
            guna2TextBox1.Text = products.Name;
            guna2TextBox2.Text = products.Description;
            guna2TextBox3.Text = products.Price.ToString();
            guna2TextBox4.Text = products.StockQuantity.ToString();
            Category cat = new Category();
            cat = cat.GetSingleCategory(products.CategoryID);
            guna2ComboBox1.Text = cat.Name;
        }

         

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            int catId = cat.GetCategoryId(guna2ComboBox1.Text.ToString());
            
            Products product = new Products
            {
                ProductID = pro.ProductID,
                Name = guna2TextBox1.Text.ToString(),
                Description = guna2TextBox2.Text.ToString(),
                Price = decimal.Parse(guna2TextBox3.Text.ToString()),
                StockQuantity = int.Parse(guna2TextBox4.Text.ToString()),
                CategoryID = catId,
                ImagePath = imagePath
            };

            int res = product.EditProduct();

            if (res > 0)
            {
                MessageBox.Show("Product updated successfully");
                DashboardForm dashboardForm = new DashboardForm();
                this.Close();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Could not update product");
            }

        }
    }
}
