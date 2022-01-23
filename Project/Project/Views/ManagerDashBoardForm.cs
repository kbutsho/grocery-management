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
    public partial class ManagerDashBoardForm : Form
    {
        public ManagerDashBoardForm()
        {
            InitializeComponent();
        }
        public ManagerDashBoardForm(string username,string email,string password)
        {
            InitializeComponent();
            string output111 = String.Format("{0}", username);
            MUserName12.Text = output111;
            string output222 = String.Format("{0}", email);
            MEmail12.Text = output222;
            string output333 = String.Format("{0}", password);
            MPass12.Text = output333;
        }
        
        private void ManageProduct_Click(object sender, EventArgs e)
        {
            new ManageProductListForm().Show();
        }

        private void ManageCustomeBtn_Click(object sender, EventArgs e)
        {
            new ManageCustomerListForm().Show();
        }

        private void ManageEmployee_Click(object sender, EventArgs e)
        {
            new ManageEmployeeListForm().Show();
        }

        private void HomePageBtn22_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void SeeSalaryBtnManager_Click(object sender, EventArgs e)
        {

            string username = MUserName12.Text; // search from textbox // See salary
            dynamic manager = ManagerController.GetManager(username);
            if (manager != null)
            {

                MsalaryBox4.Text = manager.Salary;

            }
            else
            {

                MsalaryBox4.Text = "";

                MessageBox.Show("No Salary Found!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MPUpdateinfo_Click(object sender, EventArgs e)
        {
            var manager = new
            {

                UserName = MUserName12.Text,
                Email = MEmail12.Text,
                PassWord = MPass12.Text
            };
            bool result = ManagerController.UpdateManager(manager);
            if (result)
            {
                MessageBox.Show("Information Update !!");
            }
            else
            {
                MessageBox.Show("Information Not Update !!");
            }
        }

        private void ManageProductsss_Click(object sender, EventArgs e)
        {
            new OrderListForm().Show();
        }
    }
}
