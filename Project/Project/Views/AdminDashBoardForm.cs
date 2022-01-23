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
    public partial class AdminDashBoardForm : Form
    {
        public AdminDashBoardForm()
        {
            InitializeComponent();
        }

        private void ManageManagerBtn123_Click(object sender, EventArgs e)
        {
            new ManageManagerListForm().Show();
        }

        private void ManageCustomeBtn33_Click(object sender, EventArgs e)
        {
            new ManageCustomerListForm().Show();
        }

        private void ManageEmployee33_Click(object sender, EventArgs e)
        {
            new ManageEmployeeListForm().Show();
        }

        private void ManageProduct33_Click(object sender, EventArgs e)
        {
            new ManageProductListForm().Show();
        }

        private void ManageProductsss_Click(object sender, EventArgs e)
        {
            new OrderListForm().Show();
        }

        private void HomePageBtn22_Click(object sender, EventArgs e)
        {
            new HomePageForm().Show();
            this.Hide();
        }
    }
}
