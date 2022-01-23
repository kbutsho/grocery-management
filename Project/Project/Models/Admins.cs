using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project.Models
{
    public class Admins
    {
        SqlConnection conn;
        public Admins()
        {
        }
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Admins VALUES ('{0}','{1}','{2}','{3}')", admin.Name, admin.UserName, admin.Email, admin.PassWord);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result > 0) return true;
            return false;
        }
        public Admin AutheticateAdmin(string username, string email, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admins WHERE UserName='{0}' AND Email='{1}' AND PassWord='{2}'", username, email, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                admin.Email = reader.GetString(reader.GetOrdinal("Email"));
                admin.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
            }
            conn.Close();
            return admin;
        }
    }
}
