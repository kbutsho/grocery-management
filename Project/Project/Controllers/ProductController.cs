using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Controllers
{
    class ProductController
    {
        static Database db = new Database(); 
        public static Product AuthenticateProduct(string name, string price, string quantity, string catagory)
        {
            return db.Products.AutheticateProduct(name,price, quantity, catagory); // AutheticateUser from Customers  class
        }
        public static bool AddProduct(dynamic product)
        {
            Product p = new Product();
            p.Name = product.Name;
            p.Price = product.Price;
            p.Quantity = product.Quantity;
            p.Category = product.Category;

            return db.Products.AddProduct(p);
        }
        public static ArrayList GetAllProducts() // show all Products
        {
            return db.Products.GetAllProducts();
        }
        public static Product GetProduct(string name) // For Search From DashboardForm
        {
            return db.Products.GetProduct(name);
        }
        public static bool UpdateProduct(dynamic product) // Update name from DashboardForm
        {
            Product p = new Product();
            p.Name = product.Name;
            p.Price = product.Price;
            p.Quantity = product.Quantity;
            p.Category = product.Category;
            return db.Products.UpdateProduct(p);
        }
        public static bool DeleteProduct(string name) // Delete name from DashboardForm
        {
            return db.Products.DeleteProduct(name);
        }
    }

}
