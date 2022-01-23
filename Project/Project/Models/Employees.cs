using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Project.Models
{
    public class Employees
    {
        SqlConnection conn;
        public Employees()
        {
        }
        public Employees(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Employees VALUES ('{0}','{1}','{2}','{3}','{4}')", employee.Name, employee.UserName, employee.Email, employee.PassWord, employee.Salary);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result > 0) return true;
            return false;
        }
        public Employee AutheticateEmployee(string username, string email, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE UserName='{0}' AND Email='{1}' AND PassWord='{2}'", username, email, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                employee.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                employee.Salary = reader.GetString(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return employee;
        }
        public ArrayList GetAllEmployees()  // For show all Customers
        {
            ArrayList employees = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                employee.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                employee.Salary = reader.GetString(reader.GetOrdinal("Salary"));

                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
            public Employee GetEmployee(string username) // form search
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                employee.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                employee.Salary = reader.GetString(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return employee;
        }
        public bool UpdateEmployee(Employee employee) // Update For self
        {
            conn.Open();
            string query = String.Format("UPDATE Employees SET Email='{0}', PassWord='{1}' WHERE UserName='{2}'", employee.Email,employee.PassWord, employee.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        //UpdateEmployeePassWord

        public bool UpdateEmployeeInfo(Employee employee) // Update For Management
        {
            conn.Open();
            string query = String.Format("UPDATE Employees SET Name='{0}', Email='{1}', PassWord='{2}', Salary='{3}' WHERE UserName='{4}'", employee.Name, employee.Email, employee.PassWord, employee.Salary, employee.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        //Delete users
        public bool DeleteEmployee(string username) // delete from DashBoardForm
        {
            conn.Open();
            string query = String.Format("DELETE FROM Employees WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
