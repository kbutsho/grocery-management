using Project.Controllers;
using Project.Models;
using System;
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
    public partial class CustomersRegistrationForm : Form
    {
        public CustomersRegistrationForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CMRegBtn_Click(object sender, EventArgs e)
        {
            /*
            var customer = new
            {
                Name = CMRegNameInput.Text,
                UserName = CMUserNameRegBox.Text,
                Email = CMEmailRegInput.Text,
                PassWord = CMPassWordBoxReg.Text
            };
            var result = CustomerController.AddCustomer(customer);
            
            
            if(result)
            {

                /*if (CMRegNameInput.Text.Equals(""))
                {
                    MessageBox.Show("Name Required");
                }
                if (CMUserNameRegBox.Text.Equals(""))
                {
                    MessageBox.Show("UserName Required");
                }
                if (CMEmailRegInput.Text.Equals(""))
                {
                    MessageBox.Show("Email Required");
                }
                if (CMPassWordBoxReg.Text.Equals(""))
                {
                    MessageBox.Show("passWord Required");
                }*///



            /*    new HomePageForm().Show();
                MessageBox.Show("Yor are Registered !!");        
            }
            else
            {
                MessageBox.Show("Not Registered"); // Its Not working 
            }
            */
            string Name = CMRegNameInput.Text;
            string UserName = CMUserNameRegBox.Text;
            string Email = CMEmailRegInput.Text;
            string PassWord = CMPassWordBoxReg.Text;
            
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("INSERT INTO Customers VALUES('{0}','{1}','{2}','{3}')", Name, UserName, Email, PassWord);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                new CustomersLoginForm().Show();
                this.Hide();
                MessageBox.Show("Yor are Registered !!\n\nNow Login Here !!");
            }
            else
            {
                MessageBox.Show("Yor are Not Registered !!");
            }
            

        }
    }
}
