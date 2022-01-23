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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void A_LoginBtn_Click(object sender, EventArgs e)
        {
            string username = A_UserNameBox.Text;
            string email = A_EmailBox.Text;
            string password = A_PassWordBox.Text;
            var result = AdminController.AuthenticateAdmin(username, email, password);
            if (result != null)
            {
                new AdminDashBoardForm().Show();
                MessageBox.Show("Welcome Admin!!");
                this.Hide();
            }
            else
            {
                if (A_UserNameBox.Text.Equals(""))
                {
                    MessageBox.Show("UserName Required");
                }
                if (A_EmailBox.Text.Equals(""))
                {
                    MessageBox.Show("Email Required");
                }
                if (A_PassWordBox.Text.Equals(""))
                {
                    MessageBox.Show("PassWord Required");
                }
                else
                {
                    MessageBox.Show("Invalid Admin!!");
                }
            }
            this.Hide();
        }
    }
}
