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
    public partial class ProductPage : Form
    {
        private string username;

        public ProductPage()
        {
            InitializeComponent();
            var ds = ProductController.GetAllProducts(); // show all 
            ProductDataGridView.DataSource = ds;
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {

        }

        private void HomePageBtn111_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void CustomerDashboardBtn_Click(object sender, EventArgs e)
        {
            // new CustomerDashBoardForm(string username string email,string password).Show();
        }

        private void SearchButtonForProducts_Click(object sender, EventArgs e)
        {
            string name = ProducBox222.Text; // search 
            dynamic product = ProductController.GetProduct(name);
            if (product != null)
            {
                ProNameBox211.Text = product.Name;
                ProPriceBox211.Text = product.Price;
                ProQuantityBox211.Text = product.Quantity;
                ProPriceCateGoryBox211.Text = product.Category;
            }
            else
            {
                ProNameBox211.Text = "";
                ProPriceBox211.Text = "";
                ProQuantityBox211.Text = "";
                ProPriceCateGoryBox211.Text = "";
                MessageBox.Show("Product Not Available!!\n\nChoose Another One !!");
            }
        }

        private void BuyNowBtn_Click(object sender, EventArgs e)
        {


           /* string name = ProNameBox211.Text;
            string price = ProPriceBox211.Text;
            string quantity = ProQuantityBox211.Text;
            string category = ProPriceCateGoryBox211.Text;
            var result = ProductController.AuthenticateProduct(name, price, quantity,category);
            if (result != null)
            {

                new OrderPageForm(name, price, quantity, category).Show();
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
           */

            string name = ProNameBox211.Text;
            string price = ProPriceBox211.Text;
            string quantity = ProQuantityBox211.Text;
            string category = ProPriceCateGoryBox211.Text;
            bool hasError = false;
            if (ProQuantityBox211.Text.Equals(""))
            {
                MessageBox.Show("Please Select Quantity");
                hasError = true;
            }
            else
            {
                quantity = ProQuantityBox211.Text;
            }
           
            if (!hasError)
            {
                new OrderPageForm(name, price, quantity, category).Show();
            }
            else
            {
                MessageBox.Show("SomeThing Wrong !!");
            }
            this.Hide();

            }

        private void CdashBoard_Click(object sender, EventArgs e)
        {
            new CustomerDashBoardForm().Show();
            this.Hide();
        }

        private void DeleteOrder121212_Click(object sender, EventArgs e)
        {
            
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ProductDataGridView.Rows[e.RowIndex];

                ProNameBox211.Text = row.Cells["Name"].Value.ToString();
                ProPriceBox211.Text = row.Cells["Price"].Value.ToString();
                ProQuantityBox211.Text = row.Cells["Quantity"].Value.ToString();
                ProPriceCateGoryBox211.Text = row.Cells["Category"].Value.ToString();
            }
        }
    }
}
