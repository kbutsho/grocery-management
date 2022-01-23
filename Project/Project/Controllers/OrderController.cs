using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    class OrderController
    {
        static Database db = new Database();
        public static Order AuthenticateOrder(string productname, string productprice, string productquantity, string productcategory, string customername, string customerphone, string customeremail, string customerlocation)
        {
            return db.Orders.AutheticateOrder(productname, productprice, productquantity, productcategory, customername, customerphone, customeremail, customerlocation); 
        }
        public static bool AddOrder(dynamic order)
        {
            Order o = new Order();
            o.ProductName = order.ProductName;
            o.ProductPrice = order.ProductPrice;
            o.ProductQuantity = order.ProductQuantity;
            o.ProductCategory = order.ProductCategory;
            o.CustomerName = order.CustomerName;
            o.CustomerPhone = order.CustomerPhone;
            o.CustomerEmail = order.CustomerEmail;
            o.CustomerLocation = order.CustomerLocation;

            return db.Orders.AddOrder(o);
        }
        public static ArrayList GetAllOrders() // show all Order
        {
            return db.Orders.GetAllOrders();
        }
        public static bool DeleteOrder(string productname) // Delete name from DashboardForm
        {
            return db.Orders.DeleteOrder(productname);
        }
    }
}
