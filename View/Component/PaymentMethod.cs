using OSMS.PublicClasses;
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
    public partial class PaymentMethod : UserControl
    {
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SessionManager.SetPymentMethod("PayOnDeliver");
            MessageBox.Show("PaymentMethode Selected Successfully");

        }
    }
}
