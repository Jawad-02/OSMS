using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSMS.View.Component.Headers
{
    public partial class DashboardProductHeader : UserControl
    {
        public DashboardProductHeader(int productCount)
        {
            InitializeComponent();
            label2.Text = "Prouduct Count Avilable: " + productCount.ToString();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            Form form1 = this.FindForm();
            form1.Close();
            form.Show();
        }
    }
}
