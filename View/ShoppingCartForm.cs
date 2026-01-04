using OSMS.PublicClasses;
using OSMS.View.Component;
using OSMS.Models;

namespace OSMS.View
{
    public partial class ShoppingCartForm : Form
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            int count = 0;
            foreach (var item in SessionManager.ShoppingCartItems)
            {
                count++;
            }
            label1.Text = "ItemCount: " + count.ToString();
            LoadAllItems();

        }
        private void LoadAllItems()
        {
            foreach (ShoppingCartItems item in SessionManager.ShoppingCartItems)
            {
                CatrItem card = new CatrItem(item);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // go to check out page 
            if (SessionManager.ShoppingCartItems.Count == 0)
            {

                MessageBox.Show("You dont have any item please add sum item first");
                this.Close();
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm();
                this.Close();
                checkoutForm.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
