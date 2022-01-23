using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;
using System.Collections;

namespace Project.Controllers
{
    class CustomerController
    {
        static Database db = new Database();
        public static Customer AuthenticateCustomer(string username, string email, string password)
        {
            return db.Customers.AutheticateCustomer(username, email, password); // AutheticateUser from Customers  class
        }
        public static bool AddCustomer(dynamic customer) // for add
        {
            Customer c = new Customer();
            c.Name = customer.Name;
            c.UserName = customer.UserName;
            c.Email = customer.Email;
            c.PassWord = customer.PassWord;
            
            return db.Customers.AddCustomer(c);
        }
        public static ArrayList GetAllCustomers() // show all users
        {
            return db.Customers.GetAllCustomers();
        }
        public static Customer GetCustomer(string username) // For Search From DashboardForm
        {
            return db.Customers.GetCustomer(username);
        }
        public static bool UpdateCustomer(dynamic customer) // Update For Self
        {
            Customer c = new Customer();
            //c.Name = customer.Name;
            c.UserName = customer.UserName;
            c.Email = customer.Email;
            c.PassWord = customer.PassWord;
            return db.Customers.UpdateCustomer(c);
        }
         // UpdateCustomerPassWord
         public static bool UpdateCustomerInfo(dynamic customer) // Update For manageMent
            {
            Customer c = new Customer();
            c.Name = customer.Name;
            c.UserName = customer.UserName;
            c.Email = customer.Email;
            c.PassWord = customer.PassWord;
            return db.Customers.UpdateCustomerInfo(c);
            }
        public static bool DeleteCustomer(string username) // Delete name from DashboardForm
        {
            return db.Customers.DeleteCustomer(username);
        }
    }
}
