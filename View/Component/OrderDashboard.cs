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
    public partial class OrderDashboard : UserControl
    {
        public Orders Orders { get; set; }
        public OrderDashboard(Orders order)
        {
            InitializeComponent();
            User user = new User();
            this.Orders = order;    
            label1.Text = user.GetUser(order.UserID).UserName + "'s Order";
            label2.Text = order.OrderDate.ToString();
            label3.Text = order.TotalAmount.ToString();
            label4.Text = order.OrderStatus.ToString();

            dgvOrderItems.ColumnHeadersHeight = 45;
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            dgvOrderItems.Rows.Clear();

            OrderItems oi = new OrderItems();
            var items = oi.GetOrderItemsWithProduct(Orders.OrderID);

            foreach (var item in items)
                dgvOrderItems.Rows.Add(item.ProductName, item.Quantity);
        }



        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string newStatues = guna2ComboBox1.Text;
            int res = Orders.CangeStatus(Orders.OrderID, newStatues);
            if(res > 0)
            {
                MessageBox.Show("OrderChaned Successfully");
                Form f = this.FindForm();
                DashboardForm dashboardForm = new DashboardForm();
                f.Close();
                dashboardForm.Show();

            }
            else
            {
                MessageBox.Show("can not change the status");
            }
        }
    }
}
