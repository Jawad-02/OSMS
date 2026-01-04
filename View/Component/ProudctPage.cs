
using OSMS.Models;
using OSMS.View;


namespace OSMS.View.Component
{
    public partial class ProudctPage : UserControl
    {
        Products Products { get; set; }
        public ProudctPage(Products product)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SingleProductFormForm1 form = new SingleProductFormForm1(Products);
            form.Show();
        }

        private void ProudctPage_Click(object sender, EventArgs e)
        {
            // open the single product page 
            SingleProductFormForm1 form = new SingleProductFormForm1(Products);
            form.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // go to single page item 
            SingleProductFormForm1 form = new SingleProductFormForm1(Products);
            form.Show();
        }

        private void ProudctPage_Load(object sender, EventArgs e)
        {

        }
    }
}
