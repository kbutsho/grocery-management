using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Project.Models;

namespace Project.Models
{
    public class Database
    {
        public Customers Customers { get; set; }
        public Products Products { get; set; }
        public Employees Employees { get; set; }
        public Managers Managers { get; set; }
        public Admins Admins { get; set; }
        public Orders Orders { get; set; }

        // First Connection
        public Database()
        {
            string connString = "Server=DESKTOP-VKVJ2PU;Integrated Security=true;Database=Project";
            SqlConnection conn = new SqlConnection(connString);
            Customers = new Customers(conn);
            Products = new Products(conn);
            Employees = new Employees(conn);
            Managers = new Managers(conn);
            Admins = new Admins(conn);
            Orders = new Orders(conn);
        }

         //Single Connection
        public static SqlConnection ConnectDB() 
        {
            string conString = "Server=DESKTOP-VKVJ2PU;Database=Project;Integrated Security=true";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
    }
}
