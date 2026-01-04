using OSMS.Models;

namespace OSMS.View.Component.Headers
{
    public partial class OrderUser : UserControl
    {
        public OrderUser(Orders order)
        {
            InitializeComponent();
            label1.Text = "OrderDate: " + order.OrderDate.ToString();
            label2.Text = "TotalAmount: " + order.TotalAmount.ToString() + "$";
            label3.Text = "OrderDate: " + order.OrderStatus.ToString();
        }
    }
}
