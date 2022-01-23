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
    public partial class OrderPageForm : Form
    {

        // SqlConnection conn;

        /* public OrderPageForm(SqlConnection conn)
         {
             this.conn = conn;
         }
        */
        public OrderPageForm()
        {
            InitializeComponent();
        }
        public OrderPageForm(string name, string price, string quantity, string category)
        {
            InitializeComponent();
            string output1 = String.Format("{0}", name);
            OrderProductName.Text = output1;
            string output2 = String.Format("{0}", price);
            OrderProductPrice.Text = output2;
            string output3 = String.Format("{0}", quantity);
            OrderProductQuantity.Text = output3;
            string output4 = String.Format("{0}", category);
            OrderProductCategory.Text = output4;


        }
       
        
        private void OrderPageForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyNowbtn3333_Click(object sender, EventArgs e) // add order to database
        {
            /*

            var order = new
            {
                ProductName = OrderProductName.Text,
                ProductPrice = OrderProductPrice.Text,
                ProductQuantity = OrderProductQuantity.Text,
                ProductCategory = OrderProductCategory.Text,
                CustomerName = OrderUpdateNameBox.Text,
                CustomerPhone = OrderUserNameBox.Text,
                CustomerEmail = OrdereEmailBox.Text,
                CustomerLocation = OrderCustomerLoaction.Text

            };
            var result = OrderController.AddOrder(order);
            if (result)
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
                }

                MessageBox.Show("Place Order !!");
            }
            else
            {
                MessageBox.Show("Not Place Order"); // Its Not working // problem !!
            }
            */
            string ProductName = OrderProductName.Text;
            string ProductPrice = OrderProductPrice.Text;
            string ProductQuantity = OrderProductQuantity.Text;
            string ProductCategory = OrderProductCategory.Text;
            string CustomerName = OrderUpdateNameBox.Text;
            string CustomerPhone = OrderUserNameBox.Text;
            string CustomerEmail = OrdereEmailBox.Text;
            string CustomerLocation = OrderCustomerLoaction.Text;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("INSERT INTO Orders VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", ProductName, ProductPrice, ProductQuantity, ProductCategory, CustomerName, CustomerPhone, CustomerEmail, CustomerLocation);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Order Placed !!\n\nThanks For Shopping !!");
            }
            else
            {
                MessageBox.Show("Order Not Placed");
            }
            conn.Close();
           


        }

        private void HomepageBtn1222_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void Shoppagebtn121212_Click(object sender, EventArgs e)
        {
            new ProductPage().Show();
            this.Hide();
        }

        private void CustomerdashBoard1212_Click(object sender, EventArgs e)
        {
            new CustomerDashBoardForm().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteOrder_Click(object sender, EventArgs e) // delete
        {
            
            var r = OrderController.DeleteOrder(OrderProductName.Text);
            if (r)
            {
                MessageBox.Show("Order Cancel !!");
            }
            else
            {
                MessageBox.Show("Order Not Cancel !!");
            }
            
        }
    }
}
