using OSMS.Models;
using OSMS.View.Component;


namespace OSMS.PublicClasses
{
    public static class SessionManager
    {
        public static decimal TotalOrderAmount { get; set; } = 0;
        public static int UserID { get; private set; }

        public static string Role { get; private set; }
        public static User User { get; private set; }

        public static string PymentMethod { get; private set; }

        public static ShippingAddresses SelectedAddress { get; private set; }

        public static List<Orders> Orders { get; private set; } = new List<Orders>();

        public static List<ShoppingCartItems> ShoppingCartItems { get; private set; } = new List<ShoppingCartItems>();

        public static List<ShippingAddresses> ShippingAddresses { get; private set; } = new List<ShippingAddresses>();

        public static void SetUserID(int userID) {
            UserID = userID;
        }
        public static void SetOrders(List<Orders> orders)
        {
            Orders = orders;
        }
        public static void SetPymentMethod(string payment)
        {
            PymentMethod = payment;
        }
        public static void SetShippingAddresses(List<ShippingAddresses> shippingAddresses)
        {
            ShippingAddresses = shippingAddresses;
        }
        public static void SetSelectedAddress(ShippingAddresses Address)
        {
            SelectedAddress = Address;
        }

        public static void SetShoppingCartItems(List<ShoppingCartItems> shoppingCartItems)
        {
            ShoppingCartItems = shoppingCartItems;
        }

        public static void SetRole(string role)
        {
            Role = role;
        }
        public static void SetUser(User user)
        {
            User = user;
        }

        public static void IncreaseTotalAmount(decimal Amount)
        {
            TotalOrderAmount += Amount;
        }
        public static void ResetTotalAmount()
        {
            TotalOrderAmount = 0;
        }

        
        public static void ClearSession()
        {
            UserID = 0;
            Role = string.Empty;
            // User = null;

            Orders = new List<Orders>();
            ShoppingCartItems = new List<ShoppingCartItems>();
            ShippingAddresses = new List<ShippingAddresses>();
        }


    }
}
