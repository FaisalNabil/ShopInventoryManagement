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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            AddItemForm addItemForm = new AddItemForm();
            
        }
        
        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "EditEmployee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //this.Hide();
                MessageBox.Show("0 rows update");
            }
        }

        private void salesWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.Show();
            this.Hide();
            saleForm.employeeNameLabel.Text = "Admin";
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.Show();
            this.Hide();
        }

        private void adminDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "EditEmployee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //this.Hide();
                MessageBox.Show("0 rows deleted");
            };
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
        }
    }
}
