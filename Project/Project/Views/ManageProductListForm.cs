using Project.Controllers;
using Project.Models;
using System;
using System.Collections;
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
    public partial class ManageProductListForm : Form
    {
        public ManageProductListForm()
        {
            InitializeComponent();
            var product = GetListOfProducts();
            ProductsDataGridView.DataSource = product;
        }

        private void ManageProductListForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string Name = ProName.Text;
            string Price = ProPrice.Text;
            string Quantity = ProQuantity2.Text;
            string Category  = ProCateGory.Text;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("INSERT INTO Products VALUES('{0}','{1}','{2}','{3}')", Name, Price, Quantity, Category);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Product Added !!");
            }
            else
            {
                MessageBox.Show("Products Not Added !!");
            }
            conn.Close();
            var product = GetListOfProducts();
            ProductsDataGridView.DataSource = product;
        }
        private ArrayList GetListOfProducts()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList products = new ArrayList();
            while (reader.Read())
            {
                Product p = new Product();
                p.Name = reader.GetString(reader.GetOrdinal("Name"));
                p.Price = reader.GetString(reader.GetOrdinal("Price"));
                p.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                p.Category = reader.GetString(reader.GetOrdinal("Category"));

                products.Add(p);
            }
            conn.Close();
            return products;
        }

        private void SearchButton_Click(object sender, EventArgs e)  // search from textbox
        {
            string name = SearchBox2.Text; // search from textbox
            dynamic product = ProductController.GetProduct(name);
            if (product != null)
            {
                ProNameBox2.Text= product.Name;
                ProPriceCateGoryBox2.Text = product.Price;
                ProPriceBox2.Text = product.Quantity;
                ProQuantityBox2.Text= product.Category;
            }
            else
            {
                ProNameBox2.Text = "";
                ProPriceCateGoryBox2.Text = "";
                ProPriceBox2.Text = "";
                ProQuantityBox2.Text = "";
                MessageBox.Show("No Product Found !!");
            }
        }

        private void UpdateBtn2_Click(object sender, EventArgs e) // Update btn
        {
            var product = new
            {
                Name = ProNameBox2.Text,
                Price = ProPriceBox2.Text,
                Quantity = ProQuantityBox2.Text,
                Category = ProPriceCateGoryBox2.Text
            };
            bool result = ProductController.UpdateProduct(product);
            if (result)
            {
                MessageBox.Show("Product Updated !!");
            }
            else
            {
                MessageBox.Show("Product Not Updated !!");
            }
            var ds = ProductController.GetAllProducts(); // show all 
            ProductsDataGridView.DataSource = ds;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var r = ProductController.DeleteProduct(ProNameBox2.Text);
            if (r)
            {
                MessageBox.Show("Product Delete !!");
            }
            else
            {
                MessageBox.Show("Product Not Delete !!");
            }
            var ds = ProductController.GetAllProducts(); // show all 
            ProductsDataGridView.DataSource = ds;
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }

        private void ProNameBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ProPriceBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ProQuantityBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProPriceCateGoryBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoEmp_Click(object sender, EventArgs e)
        {
            new EmployeeDashBoardForm().Show();
            this.Hide();
        }

        private void PriceUpdateBtn_Click(object sender, EventArgs e) // searech btn
        {
            /*string name = SearchBox2.Text; // search from textbox
            dynamic product = ProductController.GetProduct(name);
            if (product != null)
            {
                
                ProPriceBox2.Text = product.Price;
                MessageBox.Show("Price  Update !!");
           
            }
            else
            {
                
                ProQuantityBox2.Text = "";
               
                MessageBox.Show("Price Not Update !!");
            }
            */
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ProductsDataGridView.Rows[e.RowIndex];

                ProNameBox2.Text = row.Cells["Name"].Value.ToString();
                ProPriceBox2.Text = row.Cells["Price"].Value.ToString();
                ProQuantityBox2.Text = row.Cells["Quantity"].Value.ToString();
                ProPriceCateGoryBox2.Text = row.Cells["Category"].Value.ToString();
            }
        }
    }
}
