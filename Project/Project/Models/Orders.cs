using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Orders
    {
        SqlConnection conn;
        public Orders()
        {
        }
        public Orders(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddOrder(Order order)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Orders VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", order.ProductName, order.ProductPrice, order.ProductQuantity, order.ProductCategory,order.CustomerName, order.CustomerPhone, order.CustomerEmail, order.CustomerLocation);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result > 0) return true;
            return false;
        }
        public Order AutheticateOrder(string productname, string productprice, string productquantity, string productcategory, string customername, string customerphone, string customeremail, string customerlocation)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Orders WHERE ProductName='{0}' AND ProductPrice='{1}' AND ProductQuantity='{2}'  AND ProductCategory='{3}'  AND CustomerName='{4}'  AND CustomerPhone='{5}' AND CustomerEmail='{6}' AND CustomerLocation='{7}'", productname, productprice, productquantity, productcategory, customername, customerphone, customeremail, customerlocation);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order = null;
            while (reader.Read())
            {
                order = new Order();
                order.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                order.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                order.ProductPrice = reader.GetString(reader.GetOrdinal("ProductPrice"));
                order.ProductQuantity = reader.GetString(reader.GetOrdinal("ProductQuantity"));
                order.ProductCategory = reader.GetString(reader.GetOrdinal("ProductCategory"));
                order.CustomerName = reader.GetString(reader.GetOrdinal("CustomerName"));
                order.CustomerPhone = reader.GetString(reader.GetOrdinal("CustomerPhone"));
                order.CustomerEmail = reader.GetString(reader.GetOrdinal("CustomerEmail"));
                order.CustomerLocation = reader.GetString(reader.GetOrdinal("CustomerLocation"));
            }
            conn.Close();
            return order;
        }
        public ArrayList GetAllOrders()  // For show all Customers
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                order.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                order.ProductPrice = reader.GetString(reader.GetOrdinal("ProductPrice"));
                order.ProductQuantity = reader.GetString(reader.GetOrdinal("ProductQuantity"));
                order.ProductCategory = reader.GetString(reader.GetOrdinal("ProductCategory"));
                order.CustomerName = reader.GetString(reader.GetOrdinal("CustomerName"));
                order.CustomerPhone = reader.GetString(reader.GetOrdinal("CustomerPhone"));
                order.CustomerEmail = reader.GetString(reader.GetOrdinal("CustomerEmail"));
                order.CustomerLocation = reader.GetString(reader.GetOrdinal("CustomerLocation"));

                orders.Add(order);
            }
            conn.Close();
            return orders;
        }
        public bool DeleteOrder(string productname) // delete Order
        {
            conn.Open();
            string query = String.Format("DELETE FROM Orders WHERE ProductName='{0}'", productname);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
