using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Project.Models
{
    public class Products
    {
        SqlConnection conn;
        public Products()
        {
        }
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddProduct(Product product)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Products VALUES ('{0}','{1}','{2}','{3}')", product.Name, product.Price, product.Quantity, product.Category);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result > 0) return true;
            return false;
        }
        public Product AutheticateProduct(string name, string price, string quantity, string category)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Products WHERE Name='{0}' AND Price='{1}' AND Quantity='{2}' AND Category='{3}'", name, price, quantity, category);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Price = reader.GetString(reader.GetOrdinal("Price"));
                product.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                product.Category = reader.GetString(reader.GetOrdinal("Category"));
            }
            conn.Close();
            return product;
        }
        public ArrayList GetAllProducts()  // For show all products
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Price = reader.GetString(reader.GetOrdinal("Price"));
                product.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                product.Category = reader.GetString(reader.GetOrdinal("Category"));

                products.Add(product);
            }
            conn.Close();
            return products;
        }
        public Product GetProduct(string name) // form search
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Products WHERE Name='{0}'",name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Price = reader.GetString(reader.GetOrdinal("Price"));
                product.Quantity = reader.GetString(reader.GetOrdinal("Quantity"));
                product.Category = reader.GetString(reader.GetOrdinal("Category"));

            }
            conn.Close();
            return product;
        }
        public bool UpdateProduct(Product product) // For Update    // Query Problem Here 
        {
            conn.Open();
            string query = String.Format("UPDATE Products SET Price='{0}', Quantity='{1}' WHERE Name='{2}'", product.Price, product.Quantity,product.Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        //Delete Product
        public bool DeleteProduct(string name) // delete from DashBoardForm
        {
            conn.Open();
            string query = String.Format("DELETE FROM Products WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
