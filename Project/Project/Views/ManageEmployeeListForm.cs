using Project.Controllers;
using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class ManageEmployeeListForm : Form
    {
        public ManageEmployeeListForm()
        {
            InitializeComponent();
            var employee = GetListOfEmployees();
            EmployeeDataGridView.DataSource = employee;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageEmployeeListForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e) // Add btn
        {
            string Name = EmployeeNameBox12.Text;
            string UserName = EmployeeUserNameBox12.Text;
            string Email = EmployeeEmailBox12.Text;
            string PassWord = EmployeePassBox12.Text;
            string Salary = EmployeeSalaryBox12.Text;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("INSERT INTO Employees VALUES('{0}','{1}','{2}','{3}','{4}')", Name, UserName, Email, PassWord,Salary);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Employee Added !!");
            }
            else
            {
                MessageBox.Show("Employee Not Added!!");
            }
            conn.Close();
            var customer = GetListOfEmployees();
            EmployeeDataGridView.DataSource = customer;
        }
        private ArrayList GetListOfEmployees()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList employees = new ArrayList();
            while (reader.Read())
            {
                Employee e = new Employee();
                e.Name = reader.GetString(reader.GetOrdinal("Name"));
                e.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                e.Email = reader.GetString(reader.GetOrdinal("Email"));
                e.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));
                e.Salary = reader.GetString(reader.GetOrdinal("Salary"));

                employees.Add(e);
            }
            conn.Close();
            return employees;
        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e) // Search btn
        {
            string username = EmployeeSearchBox.Text; // search from textbox
            dynamic employee = EmployeeController.GetEmployee(username);
            if (employee != null)
            {
                EmployeeUpdateNameBox.Text = employee.Name;
                EmployeeUpdateUserNameBox.Text = employee.UserName;
                EmployeeUpdateEmailBox.Text = employee.Email;
                EmployeeUpdatePassWordBox.Text = employee.PassWord;
                EmployeeUpdatesalaryBox.Text = employee.Salary;

            }
            else
            {
                EmployeeUpdateNameBox.Text = "";
                EmployeeUpdateUserNameBox.Text = "";
                EmployeeUpdateEmailBox.Text = "";
                EmployeeUpdatePassWordBox.Text = "";
                EmployeeUpdatesalaryBox.Text = "";
                MessageBox.Show("No Employee Found");
            }
        }

        private void EmployeeUpdateBtn_Click(object sender, EventArgs e) // Update For anagement 
        {
            var employee = new
            {
                Name = EmployeeUpdateNameBox.Text,
                UserName = EmployeeUpdateUserNameBox.Text,
                Email = EmployeeUpdateEmailBox.Text,
                PassWord = EmployeeUpdatePassWordBox.Text,
                Salary = EmployeeUpdatesalaryBox.Text
            };
            bool result = EmployeeController.UpdateEmployeeInfo(employee);
            if (result)
            {
                MessageBox.Show("Informtion Update !!");
            }
            else
            {
                MessageBox.Show("Informtion Not Update !!");
            }
            var ds = EmployeeController.GetAllEmployees(); // show all 
            EmployeeDataGridView.DataSource = ds;
        }

        private void EmployeeDeleteBtn_Click(object sender, EventArgs e)
        {
            var r = EmployeeController.DeleteEmployee(EmployeeUpdateUserNameBox.Text);
            if (r)
            {
                MessageBox.Show("Employee Delete !!");
            }
            else
            {
                MessageBox.Show("Employee Not Delete !!");
            }
            var ds = EmployeeController.GetAllEmployees(); // show all 
            EmployeeDataGridView.DataSource = ds;
        }

        private void HomePage20_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void BackManagerDashBoardBtn_Click(object sender, EventArgs e)
        {
            new ManagerDashBoardForm().Show();
            this.Hide();
        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.EmployeeDataGridView.Rows[e.RowIndex];

                EmployeeUpdateNameBox.Text = row.Cells["Name"].Value.ToString();
                EmployeeUpdateUserNameBox.Text = row.Cells["UserName"].Value.ToString();
                EmployeeUpdateEmailBox.Text = row.Cells["Email"].Value.ToString();
                EmployeeUpdatePassWordBox.Text = row.Cells["PassWord"].Value.ToString();
                EmployeeUpdatesalaryBox.Text = row.Cells["Salary"].Value.ToString();


            }
        }
    }
}
