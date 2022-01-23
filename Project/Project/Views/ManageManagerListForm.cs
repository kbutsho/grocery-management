using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project.Controllers;
using Project.Models;
using System.Collections;

namespace Project.Views
{
    public partial class ManageManagerListForm : Form
    {
        public ManageManagerListForm()
        {
            InitializeComponent();
            var manager = GetListOfManagers();
            ManagerDataGridView.DataSource = manager;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManageManagerListForm_Load(object sender, EventArgs e)
        {

        }

        private void ManagerAddBtn_Click(object sender, EventArgs e)
        {
            string Name = ManagerNameBox120.Text;
            string UserName = ManagerUserNameBox120.Text;
            string Email = ManagerEmailBox12.Text;
            string PassWord = ManagerPassBox12.Text;
            string Salary = ManagerSalaryBox12.Text;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("INSERT INTO Managers VALUES('{0}','{1}','{2}','{3}','{4}')", Name, UserName, Email, PassWord, Salary);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Manager Added !!");
            }
            else
            {
                MessageBox.Show("Manager Not Added!!");
            }
            conn.Close();
            var manager = GetListOfManagers();
            ManagerDataGridView.DataSource = manager;
        }
        private ArrayList GetListOfManagers()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "SELECT * FROM Managers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList managers = new ArrayList();
            while (reader.Read())
            {
                Manager m = new Manager();
                m.Name = reader.GetString(reader.GetOrdinal("Name"));
                m.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                m.Email = reader.GetString(reader.GetOrdinal("Email"));
                m.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                m.Salary = reader.GetString(reader.GetOrdinal("Salary"));

                managers.Add(m);
            }
            conn.Close();
            return managers;
        }

        private void ManagerSearchButton_Click(object sender, EventArgs e)
        {
            string username = ManagerSearchBox.Text; // search from textbox
            dynamic manager = ManagerController.GetManager(username);
            if (manager != null)
            {
                ManagerUpdateNameBox112222.Text = manager.Name;
                ManagerUpdateUserNameBox.Text = manager.UserName;
                ManagerUpdateEmailBox.Text = manager.Email;
                ManagerUpdatePassWordBox.Text = manager.PassWord;
                EmployeeUpdatesalaryBox112211.Text = manager.Salary;

            }
            else
            {
                ManagerUpdateNameBox112222.Text = "";
                ManagerUpdateUserNameBox.Text = "";
                ManagerUpdateEmailBox.Text = "";
                ManagerUpdatePassWordBox.Text = "";
                EmployeeUpdatesalaryBox112211.Text = "";
                MessageBox.Show("Manager Not Found");
            }
        }

        private void ManagerUpdateBtn_Click(object sender, EventArgs e) // Update For management
        {
            var manager = new
            {
                Name = ManagerUpdateNameBox112222.Text,
                UserName = ManagerUpdateUserNameBox.Text,
                Email = ManagerUpdateEmailBox.Text,
                PassWord = ManagerUpdatePassWordBox.Text,
                Salary = EmployeeUpdatesalaryBox112211.Text
            };
            bool result = ManagerController.UpdateManagerInfo(manager);
            if (result)
            {
                MessageBox.Show("Information Updated !!");
            }
            else
            {
                MessageBox.Show("Information Not Update!!");
            }
            var ds = ManagerController.GetAllManagers(); // show all 
            ManagerDataGridView.DataSource = ds;
        }

        private void ManagerDeleteBtn_Click(object sender, EventArgs e)
        {
            var r = ManagerController.DeleteManager(ManagerUpdateUserNameBox.Text);
            if (r)
            {
                MessageBox.Show("Manager Delete !1");
            }
            else
            {
                MessageBox.Show("Manager Not Delete !!");
            }
            var ds = ManagerController.GetAllManagers(); // show all 
            ManagerDataGridView.DataSource = ds;
        }

        private void BackAdminDashBoardBtn_Click(object sender, EventArgs e)
        {
           new AdminDashBoardForm().Show();
            this.Hide();
        }

        private void HomePage20_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void ManagerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ManagerDataGridView.Rows[e.RowIndex];

                ManagerUpdateNameBox112222.Text = row.Cells["Name"].Value.ToString();
                ManagerUpdateUserNameBox.Text = row.Cells["UserName"].Value.ToString();
                ManagerUpdateEmailBox.Text = row.Cells["Email"].Value.ToString();
                ManagerUpdatePassWordBox.Text = row.Cells["PassWord"].Value.ToString();
                EmployeeUpdatesalaryBox112211.Text = row.Cells["Salary"].Value.ToString();


            }
        }
    }
}
