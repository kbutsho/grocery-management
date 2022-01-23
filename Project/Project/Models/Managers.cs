using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Project.Models
{
    public class Managers
    {
        SqlConnection conn;
        public Managers()
        {
        }
        public Managers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddManager(Manager manager)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Managers VALUES ('{0}','{1}','{2}','{3}','{4}')", manager.Name, manager.UserName, manager.Email, manager.PassWord, manager.Salary);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result > 0) return true;
            return false;
        }
        public Manager AutheticateManager(string username, string email, string password)    
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Managers WHERE UserName='{0}' AND Email='{1}' AND PassWord='{2}'", username, email, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager manager = null;
            while (reader.Read())
            {
                manager = new Manager();
                manager.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                manager.Name = reader.GetString(reader.GetOrdinal("Name"));
                manager.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                manager.Email = reader.GetString(reader.GetOrdinal("Email"));
                manager.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                manager.Salary = reader.GetString(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return manager;
        }
        public ArrayList GetAllManagers()  // For show all Customers
        {
            ArrayList managers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Managers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Manager manager = new Manager();
                manager.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                manager.Name = reader.GetString(reader.GetOrdinal("Name"));
                manager.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                manager.Email = reader.GetString(reader.GetOrdinal("Email"));
                manager.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                manager.Salary = reader.GetString(reader.GetOrdinal("Salary"));

                managers.Add(manager);
            }
            conn.Close();
            return managers;
        }
        public Manager GetManager(string username) // form search
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Managers WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager manager = null;
            while (reader.Read())
            {
                manager = new Manager();
                manager.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                manager.Name = reader.GetString(reader.GetOrdinal("Name"));
                manager.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                manager.Email = reader.GetString(reader.GetOrdinal("Email"));
                manager.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                manager.Salary = reader.GetString(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return manager;
        }
        public bool UpdateManager(Manager manager) // Update For Self
        {
            conn.Open();
            string query = String.Format("UPDATE Managers SET Email='{0}',PassWord='{1}' WHERE UserName='{2}'", manager.Email,manager.PassWord, manager.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        
        public bool UpdateManagerInfo(Manager manager) // Update For Management
        {
            conn.Open();
            string query = String.Format("UPDATE Managers SET Name='{0}', Email='{1}',PassWord='{2}',Salary='{3}' WHERE UserName='{4}'", manager.Name, manager.Email, manager.PassWord, manager.Salary, manager.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool DeleteManager(string username) // Delete 
        {
            conn.Open();
            string query = String.Format("DELETE FROM Managers WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
