using Project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class EmployeeDashBoardForm : Form
    {
        public EmployeeDashBoardForm()
        {
            InitializeComponent();
        }

        public EmployeeDashBoardForm( string username,string email,string password)
        {
            InitializeComponent();
            string output111 = String.Format("{0}", username);
            CUserName112222.Text = output111;
            string output222 = String.Format("{0}", email);
            CEmail222222.Text = output222;
            string output333 = String.Format("{0}", password);
            CPass33333.Text = output333;
            
        }
        
        private void EmployeeDashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void HomepageBtn_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            new ManageCustomerListForm().Show();
        }

        private void ProductGoBtn_Click(object sender, EventArgs e)
        {
            new ManageProductListForm().Show();
        }

        private void EMPUpdateinfo_Click(object sender, EventArgs e)
        {
            var employee = new
            {

                UserName = CUserName112222.Text,
                Email = CEmail222222.Text,
                PassWord = CPass33333.Text
            };
            bool result = EmployeeController.UpdateEmployee(employee);
            if (result)
            {
                MessageBox.Show("Information Update !!");
            }
            else
            {
                MessageBox.Show("Information Not Update !!");
            }
        }

        private void SeeSalaryBtn_Click(object sender, EventArgs e)
        {
            string username = CUserName112222.Text; // search from textbox // for salary
            dynamic employee = EmployeeController.GetEmployee(username);
            if (employee != null)
            {
                salaryBox44444.Text = employee.Salary;

            }
            else
            {
                /* EmployeeUpdateNameBox.Text = "";
                 EmployeeUpdateUserNameBox.Text = "";
                 EmployeeUpdateEmailBox.Text = "";
                 EmployeeUpdatePassWordBox.Text = "";
                */
                salaryBox44444.Text = "";

                MessageBox.Show("No Salary Found!!");
            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            new OrderListForm().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
