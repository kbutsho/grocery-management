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
    public partial class CustomersLoginForm : Form
    {
        public CustomersLoginForm()
        {
            InitializeComponent();
        }

        private void CMLoginBtn_Click(object sender, EventArgs e)
        {
            string username = CMUserNameBox.Text;
            string email = CMEmailBox.Text;
            string password = CMPassWordBox.Text;
            var result = CustomerController.AuthenticateCustomer(username, email, password);
            if (result != null)
            {
                new CustomerDashBoardForm(username,email,password).Show();
                this.Hide();
                MessageBox.Show("Welcome!!");
            }
            else // check required field
            
            {
                if (CMUserNameBox.Text.Equals(""))
                {
                    MessageBox.Show("UserName Required");
                }
                if (CMEmailBox.Text.Equals(""))
                {
                    MessageBox.Show("Email Required");
                }
                if (CMPassWordBox.Text.Equals(""))
                {
                    MessageBox.Show("PassWord Required");
                }
                else
                {
                    MessageBox.Show("Invalid Customer !!");
                }
               
            }
           
        }

        private void CustomersLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void CMRegBtn_Click(object sender, EventArgs e)
        {
            new CustomersRegistrationForm().Show();
            this.Hide();
        }
    }
}
