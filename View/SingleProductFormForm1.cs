using System;
using System.Collections.Generic;
using OSMS.Models;
using OSMS.PublicClasses;

namespace OSMS.View
{
    public partial class SingleProductFormForm1 : Form
    {
        Products Products { get; set; }
        public SingleProductFormForm1(Products product)
        {
            if(SessionManager.UserID > 0) { 
            this.Products = product;
            InitializeComponent();
            string imagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", product.ImagePath);
            Image image = Image.FromFile(imagePath);
            pictureBox1.Image = image;
            Category cat = new Category();
            label1.Text = product.Name;
            label2.Text = "Desctiption: " + product.Description;
            label3.Text = product.Price.ToString() + "$";
            label4.Text = "Quantity Avilable: " + product.StockQuantity.ToString();
            label5.Text = cat.GetSingleCategory(product.CategoryID).Name;
            }
            else
            {
                InitializeComponent();
                label1.Text = "You Have To be logged in to see this page";
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false; 
                label6.Visible = false;
                pictureBox1.Visible = false;
                guna2GradientButton1.Visible = false;
                guna2GradientButton1.Visible = false ;
                numericUpDown1.Visible = false;

                MessageBox.Show("You Have To be logged in to see this page");
                
            }
        }

        private void SingleProductFormForm1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            ShoppingCartItems cartItems = new ShoppingCartItems
            {
                UserID = SessionManager.UserID,
                ProductID = Products.ProductID,
                Quantity = (int)numericUpDown1.Value,
            };

            if (Products.StockQuantity > cartItems.Quantity)
            {
                int res = cartItems.AddShoppingCartItem();

                if (res > 0)
                {
                    Products.UpdateQuantity(Products.ProductID, (Products.StockQuantity - cartItems.Quantity));
                    SessionManager.SetShoppingCartItems(cartItems.GetAllShoppingCartItems(SessionManager.User.UserID));
                    MessageBox.Show("Add Successfully to the Cart");
                    this.Close();
                    
                }

            }
            else
            {
                MessageBox.Show($"NOT AVILABLE QUANTITY in the Stock availble quantity{Products.StockQuantity} your quantity is {cartItems.Quantity}");
            }


        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
