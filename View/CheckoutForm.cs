using Guna.UI2.WinForms;
using OSMS.Models;
using OSMS.PublicClasses;
using OSMS.View.Component;
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
    public partial class CheckoutForm : Form
    {
        int PageNumber = 1;
        public CheckoutForm()
        {
            InitializeComponent();
            lblTotalAmount.Visible = false;
            LoadPageContent();
            

        }
        private void LoadPageContent()
        {
            OverView.Controls.Clear();

            guna2GradientButton1.Click -= Guna2GradientButton1_Click;
            guna2GradientButton1.Click -= Decrease_Click;
            guna2GradientButton2.Click -= Increase_Click;
            guna2GradientButton2.Click -= Guna2GradientButton2_Click;


            if (PageNumber == 1)
            {
                guna2GradientButton1.Text = "Exit";
                guna2GradientButton1.Click += Guna2GradientButton1_Click;
                guna2GradientButton2.Text = "Next";
                guna2GradientButton2.Click += Increase_Click;

                label1.Text = "Cart Over View";
                SessionManager.ResetTotalAmount();

                foreach (var item in SessionManager.ShoppingCartItems)
                {
                    CartView cv = new CartView(item);
                    OverView.Controls.Add(cv);
                }

                
                lblTotalAmount.Text = $"Total: {SessionManager.TotalOrderAmount:C}";
                lblTotalAmount.Visible = true;

            }
            if (PageNumber == 2)
            {

                lblTotalAmount.Visible = false;
                guna2GradientButton1.Text = "Previous";
                guna2GradientButton1.Click += Decrease_Click;

                guna2GradientButton2.Text = "Next";
                guna2GradientButton2.Click += Increase_Click;

                label1.Text = "AddressConformation";

                foreach (var item in SessionManager.ShippingAddresses)
                {
                    UserAdresses UA = new UserAdresses(item);
                    OverView.Controls.Add(UA);
                }

                if(OverView.Controls.Count == 0)
                {
                    MessageBox.Show("You Dont have any address please add adderss first");
                    this.Close();
                    AddAddressForm form = new AddAddressForm();
                    form.Show();
                }

            }
            if (PageNumber == 3)
            {
                guna2GradientButton2.Text = "Place Order";
                guna2GradientButton2.Click += Guna2GradientButton2_Click;
                guna2GradientButton1.Text = "Previous";
                guna2GradientButton1.Click += Decrease_Click;

                label1.Text = "Chooes Payment Methode";

                PaymentMethod payment = new PaymentMethod();
                OverView.Controls.Add(payment);
            }
            
        }

        private void Guna2GradientButton2_Click(object? sender, EventArgs e)
        {
           // add to order Table
           Orders order = new Orders{
                UserID = SessionManager.User.UserID,
                OrderDate = DateTime.Now,
                TotalAmount = SessionManager.TotalOrderAmount,
                OrderStatus = "Pending"
           };
            int newOrderId = order.AddOrder();
            if (newOrderId > 0)
            {

                foreach (var item in SessionManager.ShoppingCartItems)
                {
                    OrderItems oi = new OrderItems
                    {
                        OrderID = newOrderId,
                        ProductID = item.ProductID,
                        Quantity = item.Quantity
                    };

                    oi.AddOrderItem(oi);
                }

                MessageBox.Show("Order Placed Successfully");
                ShoppingCartItems shoppingCartItems = new ShoppingCartItems();
                int resl = shoppingCartItems.DeleteShoppingCartItemByUserID(SessionManager.User.UserID);
                if(resl > 0)
                {
                    SessionManager.ShoppingCartItems.Clear();
                    SessionManager.SetOrders(order.GetAllOrders(SessionManager.User.UserID));
                    MessageBox.Show("Shopping Cart Empty Successfully");
                    this.Close();
                    Form1 mainPage = new Form1();
                    mainPage.Show();
                }else
                {
                    MessageBox.Show("Can not empty the Shoppind Cart");
                }
            }else
            {
                MessageBox.Show("Can not Place An Order");
            }

           // reset ShoppingCart
        }
        private void Increase_Click(object? sender, EventArgs e)
        {
            PageNumber++;
            LoadPageContent();
        }
        private void Decrease_Click(object? sender, EventArgs e)
        {
            PageNumber--;
            LoadPageContent();
        }

        private void Guna2GradientButton1_Click(object? sender, EventArgs e)
        {
            
            Form fr = this.FindForm();
            fr.Close();
            ShoppingCartForm sh = new ShoppingCartForm();
            sh.Show();
        }

        

        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
