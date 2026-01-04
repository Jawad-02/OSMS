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
    public partial class LougedoutHeader : UserControl
    {
        public LougedoutHeader()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
