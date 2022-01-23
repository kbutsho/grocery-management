using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controllers;

namespace Project.Views
{
    public partial class EmployeesLoginForm : Form
    {
        public EmployeesLoginForm()
        {
            InitializeComponent();
        }

        private void EPLoginBtn_Click(object sender, EventArgs e)
        {
            string username = EPUserNameBox.Text;
            string email = EPEmailBox.Text;
            string password = EPPassWordBox.Text;
            
            var result = EmployeeController.AuthenticateEmployee(username,email,password);
            if (result != null)
            {
                new EmployeeDashBoardForm(username,email,password).Show();
                this.Hide();
                MessageBox.Show("Welcome !!");
            }
            else
            {
                if (EPUserNameBox.Text.Equals(""))
                {
                    MessageBox.Show("UserName Required");
                }
                if (EPEmailBox.Text.Equals(""))
                {
                    MessageBox.Show("Email Required");
                }
                if (EPPassWordBox.Text.Equals(""))
                {
                    MessageBox.Show("PassWord Required");
                }
                else
                {
                    MessageBox.Show("Invalid Employee!!");
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EPEmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EPUserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EPPassWordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
