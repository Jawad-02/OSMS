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
    public partial class DashboardUsersHeader : UserControl
    {
        public DashboardUsersHeader(int UsersCount)
        {
            InitializeComponent();
            label2.Text = "The Curren Users Count is: " + UsersCount.ToString();
        }
    }
}
