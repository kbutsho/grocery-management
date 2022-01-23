using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project.Models
{
    public class Customers
    {
        SqlConnection conn;
        public Customers()
        {
        }
        public Customers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddCustomer(Customer customer) 
        {
            conn.Open();
            string query = String.Format("INSERT INTO Customers VALUES ('{0}','{1}','{2}','{3}')", customer.Name, customer.UserName, customer.Email, customer.PassWord);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result > 0) return true;
            return false;
        }
        public Customer AutheticateCustomer(string username, string email, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customers WHERE UserName='{0}' AND Email='{1}' AND PassWord='{2}'", username, email, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                customer.PassWord = reader.GetString(reader.GetOrdinal("PassWord")); 
            }
            conn.Close();
            return customer;
        }
        public ArrayList GetAllCustomers()  // For show all Customers
        {
            ArrayList customers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                customer.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));

                customers.Add(customer);
            }
            conn.Close();
            return customers;
        }
        public Customer GetCustomer(string username) // form search
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customers WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                customer.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
               
            }
            conn.Close();
            return customer;
        }

        public bool UpdateCustomer(Customer customer) // For  Self Update
        {
            conn.Open();
            string query = String.Format("UPDATE Customers SET Email='{0}', PassWord='{1}' WHERE UserName='{2}'", customer.Email, customer.PassWord, customer.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        

         public bool UpdateCustomerInfo(Customer customer) // For ManageMent Update
        {
            conn.Open();
            string query = String.Format("UPDATE Customers SET Name='{0}', Email='{1}', PassWord='{2}' WHERE UserName='{3}'", customer.Name , customer.Email, customer.PassWord, customer.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        
        public bool DeleteCustomer(string username) // delete from DashBoardForm
        {
            conn.Open();
            string query = String.Format("DELETE FROM Customers WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
       
    }
}
