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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();

            var ds = OrderController.GetAllOrders(); // show all 
            OrderListDataGridView.DataSource = ds;
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {

        }

        private void Homegooooooooooooooooooooooooooo_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
        }

        private void productgoooooooooooooooooooo_Click(object sender, EventArgs e)
        {
            new ManageProductListForm().Show();
            this.Hide();
        }

        private void EmployeeDashBoardgoo_Click(object sender, EventArgs e)
        {
            new EmployeeDashBoardForm().Show();
            this.Hide();
        }
    }
}
