using OSMS.PublicClasses;
using System.Data.SqlClient;


namespace OSMS.Models
{
    public class Payments : DatabaseConnection
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }



       

    }
}
