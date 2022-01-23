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
using Project.Models;
using System.Data.SqlClient;
using System.Collections;


namespace Project.Views
{
    
    
    public partial class ManageCustomerListForm : Form
    {
       //SqlConnection conn;

        public ManageCustomerListForm()
        {
            InitializeComponent();
            var ds = CustomerController.GetAllCustomers(); // show all 
            CustomersDataGridView2.DataSource = ds;


            var customer = GetListOfCustomers();
            CustomersDataGridView2.DataSource = customer;
        }   
        private void ManageCustomerListForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CustomersDataGridView2.Rows[e.RowIndex];

                UpdateNameBox.Text = row.Cells["Name"].Value.ToString();
                UpdateUserNameBox.Text = row.Cells["UserName"].Value.ToString();
                UpdateEmailBox.Text = row.Cells["Email"].Value.ToString();
                UpdatePassWordBox.Text = row.Cells["PassWord"].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)  // Add Button
        {

            //conn.Open();
            /* var customer = new
             {
                 Name = NameBox.Text,
                 UserName = UserNameBox.Text,
                 Email = EmailBox.Text,
                 PassWord = PassBox.Text
             };
             var result = CustomerController.AddCustomer(customer);
             if (result)
             {

                 MessageBox.Show(" Add User");
             }
             else
             {
                 MessageBox.Show("Could not Add User");
             }
             //conn.Close();
             var ds = CustomerController.GetAllCustomers(); // show all 
             CustomersDataGridView2.DataSource = ds;
             */


            //New Database Connection 
           
            string Name = NameBox.Text;
            string UserName = UserNameBox.Text;
            string Email = EmailBox.Text;
            string PassWord = PassBox.Text;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("INSERT INTO Customers VALUES('{0}','{1}','{2}','{3}')", Name, UserName, Email,PassWord);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Customer Added !!");
            }
            else
            {
                MessageBox.Show("Customer Not Added !!");
            }
            conn.Close();
            var customer = GetListOfCustomers();
            CustomersDataGridView2.DataSource = customer;
        }
        private ArrayList GetListOfCustomers()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList customers = new ArrayList();
            while (reader.Read())
            {
                Customer c = new Customer();
                c.Name = reader.GetString(reader.GetOrdinal("Name"));
                c.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                c.Email = reader.GetString(reader.GetOrdinal("Email"));
                c.PassWord = reader.GetString(reader.GetOrdinal("PassWord"));

                customers.Add(c);
            }
            conn.Close();
            return customers;
        }

        private void SearchButton_Click(object sender, EventArgs e) // Search Btn
        {
            string username = SearchBox.Text; // search from textbox
            dynamic customer = CustomerController.GetCustomer(username);
            if (customer != null)
            {
                UpdateNameBox.Text = customer.Name;
                UpdateUserNameBox.Text = customer.UserName;
                UpdateEmailBox.Text = customer.Email;
                UpdatePassWordBox.Text = customer.PassWord;
            }
            else
            {
                UpdateNameBox.Text = "";
                UpdateUserNameBox.Text = "";
                UpdateEmailBox.Text = "";
                UpdatePassWordBox.Text = "";
                MessageBox.Show("No Customer Found");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Update For Management
        {
            var customer = new
            {
                Name = UpdateNameBox.Text,
                UserName = UpdateUserNameBox.Text,
                Email = UpdateEmailBox.Text,
                PassWord = UpdatePassWordBox.Text
            };
            bool result = CustomerController.UpdateCustomerInfo(customer); 
            if (result)
            {
                MessageBox.Show("Customer Updated !!");
            }
            else
            {
                MessageBox.Show("Customer Not Update !!");
            }
            var ds = CustomerController.GetAllCustomers(); // show all 
            CustomersDataGridView2.DataSource = ds;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var r = CustomerController.DeleteCustomer(UpdateUserNameBox.Text);  // Delete 
            if (r)
            {
                MessageBox.Show("Customer Delete !!");
            }
            else
            {
                MessageBox.Show("Customer Not Delete !!");
            }
            var ds = CustomerController.GetAllCustomers(); // show all 
            CustomersDataGridView2.DataSource = ds;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void EmployeeDashBoardBtn_Click(object sender, EventArgs e)
        {
            new EmployeeDashBoardForm().Show();
            this.Hide();
        }
    }
}
