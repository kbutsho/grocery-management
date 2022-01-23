using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;
using System.Collections;

namespace Project.Controllers
{
    class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string username, string email, string password)
        {
            return db.Admins.AutheticateAdmin(username, email, password); 
        }
    }
}
