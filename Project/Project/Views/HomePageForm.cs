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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void HomePageCMBtn_Click(object sender, EventArgs e)
        {
            
            new CustomersLoginForm().Show();
           this.Hide();
            
            
        }

        private void HomePage_EP_Btn_Click(object sender, EventArgs e)
        {
            
            new EmployeesLoginForm().Show();
            this.Hide();

        }
        
        private void HomepageAdminBtn_Click(object sender, EventArgs e)
        {
            
            new AdminLoginForm().Show();
            this.Hide();

        }

        private void HomePageManagerBtn_Click(object sender, EventArgs e)
        {
            new ManagerLoginForm().Show();
            this.Hide();

        }
        
        
    }
}
