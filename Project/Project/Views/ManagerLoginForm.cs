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
    public partial class ManagerLoginForm : Form
    {
        public ManagerLoginForm()
        {
            InitializeComponent();
        }

        private void ManagerLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void MLoginBtn_Click(object sender, EventArgs e)
        {
            string username = MUserNameBox.Text;
            string email = MEmailBox.Text;
            string password = MPassWordBox.Text;
            var result = ManagerController.AuthenticateManager(username, email, password);
            if (result != null)
            {
                new ManagerDashBoardForm(username,email,password).Show();
                this.Hide();
                MessageBox.Show("Welcome !!");
            }
            else
            { 
                if (MUserNameBox.Text.Equals(""))
                {
                    MessageBox.Show("UserName Required");
                }
                if (MEmailBox.Text.Equals(""))
                {
                    MessageBox.Show("Email Required");
                }
                if (MPassWordBox.Text.Equals(""))
                {
                    MessageBox.Show("PassWord Required");
                }
                else
                {
                    MessageBox.Show("Invalid Manager");
                }
            }
            
        }
    }
}
