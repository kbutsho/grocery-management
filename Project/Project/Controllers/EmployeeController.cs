using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;
using System.Collections;

namespace Project.Controllers
{
    class EmployeeController
    {
        static Database db = new Database();
        public static Employee AuthenticateEmployee(string username, string email, string password)
        {
            return db.Employees.AutheticateEmployee(username, email,password); // AutheticateUser from Users class
        }
        public static bool AddEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Name = employee.Name;
            e.UserName = employee.UserName;
            e.Email = employee.Email;
            e.PassWord = employee.PassWord;
            e.Salary = employee.Salary;
            
            return db.Employees.AddEmployee(e);
        }
        public static ArrayList GetAllEmployees() // show all users
        {
            return db.Employees.GetAllEmployees();
        }
        public static Employee GetEmployee(string username) // For Search 
        {
            return db.Employees.GetEmployee(username);
        }
        public static bool UpdateEmployee(dynamic employee) // Update For Self
        {
            Employee e = new Employee();
            //e.Name = employee.Name;
            e.UserName = employee.UserName;
            e.Email = employee.Email;
            e.PassWord = employee.PassWord;
            return db.Employees.UpdateEmployee(e);
        }
        public static bool UpdateEmployeeInfo(dynamic employee) // Update For Management
        {
            Employee e = new Employee();
            e.Name = employee.Name;
            e.UserName = employee.UserName;
            e.Email = employee.Email;
            e.PassWord = employee.PassWord;
            e.Salary = employee.Salary;
            return db.Employees.UpdateEmployeeInfo(e);
        }
        public static bool DeleteEmployee(string username) // Delete name from DashboardForm
        {
            return db.Employees.DeleteEmployee(username);
        }
    }
}
