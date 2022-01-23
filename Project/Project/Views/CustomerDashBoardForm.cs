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
    public partial class CustomerDashBoardForm : Form
    {
        public CustomerDashBoardForm()
        {
            InitializeComponent();
        }
        public CustomerDashBoardForm(string username,string email,string password)
        {
            InitializeComponent();
            string output11 = String.Format("{0}", username);
            CUserName1122.Text = output11;
            string output22 = String.Format("{0}", email);
            CEmail2222.Text = output22;
            string output33 = String.Format("{0}", password);
            CPass33.Text = output33;
           
        }
        private void HomePageBtn_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void ShoppingBtn_Click(object sender, EventArgs e)
        {
            new ProductPage().Show();
            this.Hide();
        }

        private void CustomerDashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomerUpdateinfo_Click(object sender, EventArgs e)
        {
            var customer = new
            {
               
                UserName = CUserName1122.Text,
                Email = CEmail2222.Text,
                PassWord = CPass33.Text
            };
            bool result = CustomerController.UpdateCustomer(customer);
            if (result)
            {
                MessageBox.Show("Customer Update");
            }
            else
            {
                MessageBox.Show("Customer Not Update");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
