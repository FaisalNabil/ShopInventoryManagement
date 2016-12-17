using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Inventory_Management
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }
        
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void logInFromAnotherAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeAccountForm changeAccountForm = new ChangeAccountForm();
            this.Hide();
            changeAccountForm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
        }

        private void backToAdminDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard=new AdminDashboard();
            if (employeeNameLabel.Text == "Admin")
            {
                adminDashboard.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Cannot access");
        }
    }
}
