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
    public partial class AddProductForm : Form
    {
        private string selectedFilePath;
        private string selectedExtension = ".png";
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && !string.IsNullOrEmpty(selectedFilePath))
            {
                // Specify destination folder path
                string destinationFolderPath = @"D:\C# Projects\OSMS\Images\";

                // Define file name (e.g., based on current date/time)
                string fileName = guna2TextBox1.Text.ToString();

                // Construct the destination file path
                string destinationFilePath = Path.Combine(destinationFolderPath, fileName + selectedExtension);

                try
                {
                    // Copy the file to the destination path
                    File.Copy(selectedFilePath, destinationFilePath, true);
                    MessageBox.Show("File saved successfully as: " + fileName + selectedExtension);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an image first.");
            }
            Category cat = new Category();
            int catId = cat.GetCategoryId(guna2ComboBox1.Text.ToString());

            Products products = new Products
            {
                Name = guna2TextBox1.Text.ToString(),
                Description = guna2TextBox2.Text.ToString(),
                Price = decimal.Parse(guna2TextBox3.Text.ToString()),
                StockQuantity = int.Parse(guna2TextBox4.Text.ToString()),
                CategoryID = catId,
                ImagePath = guna2TextBox1.Text.ToString() + ".png",
            };

            int res = products.AddProduct();
            if (res > 0)
            {
                MessageBox.Show("Product add Successfully");
                DashboardForm dashboardForm = new DashboardForm();
                this.Close();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Could not add product");
            }

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;

                // Display selected file path in the form's title (or any other suitable control)
                this.Text = "Selected File: " + selectedFilePath;

                // Display image in PictureBox (if needed)
                try
                {
                    pictureBox1.Image = Image.FromFile(selectedFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }

        }
    }

}
