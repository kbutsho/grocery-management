using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;
using System.Collections;

namespace Project.Controllers
{
    class ManagerController
    {
        static Database db = new Database();
        public static Manager AuthenticateManager(string username, string email, string password)
        {
            return db.Managers.AutheticateManager(username, email, password); // Autheticatemanager from Managers class
        }
        public static bool AddManager(dynamic manager)
        {
            Manager m = new Manager();
            m.Name = manager.Name;
            m.UserName = manager.UserName;
            m.Email = manager.Email;
            m.PassWord = manager.PassWord;
            m.Salary = manager.Salary;

            return db.Managers.AddManager(m);
        }
        public static ArrayList GetAllManagers() // show all users
        {
            return db.Managers.GetAllManagers();
        }
        public static Manager GetManager(string username) // For Search From DashboardForm
        {
            return db.Managers.GetManager(username);
        }
        public static bool UpdateManagerInfo(dynamic manager) // Update For Management
        {
            Manager m = new Manager();
            m.Name = manager.Name;
            m.UserName = manager.UserName;
            m.Email = manager.Email;
            m.PassWord = manager.PassWord;
            m.Salary = manager.Salary;
            return db.Managers.UpdateManagerInfo(m);
        }
        public static bool UpdateManager(dynamic manager) // Update for Self
        {
            Manager m = new Manager();
            //m.Name = manager.Name;
            m.UserName = manager.UserName;
            m.Email = manager.Email;
            m.PassWord = manager.PassWord;
            //m.Salary = manager.Salary;
            return db.Managers.UpdateManager(m);
        }
        public static bool DeleteManager(string username) // Delete name from DashboardForm
        {
            return db.Managers.DeleteManager(username);
        }
    }
}
