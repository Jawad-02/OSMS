using OSMS.Models;
using OSMS.PublicClasses;
using OSMS.View.Component;
using OSMS.View.Component.Headers;
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
    public partial class DashboardForm : Form
    {
        Products productCount = new Products();
        Orders OrderCount = new Orders();
        User UsersCount = new User();
        public DashboardForm()
        {
            InitializeComponent();
            label1.Text = "Welcome " + SessionManager.User.UserName;

        }
        private void LoadPage(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void HomePage_Click(object sender, EventArgs e)
        {

            DashboardProductHeader header = new DashboardProductHeader(productCount.GetProudctsCount());
            LoadPage(header);

            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            Products pr = new Products();
            List<Products> products = pr.GetAllProducts();

            foreach (Products p in products)
            {
                ProductDashboard pro = new ProductDashboard(p);
                flowLayoutPanel1.Controls.Add(pro);
                pro.BringToFront();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DashboardOrdersHeader header = new DashboardOrdersHeader(OrderCount.GetOrderCount());
            LoadPage(header);

            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            Orders Or = new Orders();
            List<Orders> orders = Or.GetAllOrders();
            foreach (Orders o in orders)
            {
                OrderDashboard orderDashboard = new OrderDashboard(o);
                flowLayoutPanel1.Controls.Add(orderDashboard);
                orderDashboard.BringToFront();
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DashboardUsersHeader header = new DashboardUsersHeader(UsersCount.GetUsersCount());
            LoadPage(header);

            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            User us = new User();
            List<User> users = us.GetUsers();
            foreach (User u in users)
            {
                UsersDashboard usersDashboard = new UsersDashboard(u);
                flowLayoutPanel1.Controls.Add(usersDashboard);
                usersDashboard.BringToFront();
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
