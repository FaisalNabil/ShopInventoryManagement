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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void addNewInventoryButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.Show();
        }

        private void seeInventoryListButton_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            this.Hide();
            inventoryForm.Show();
        }

        private void thisDayActivityButton_Click(object sender, EventArgs e)
        {
            ThisDayActivityForm thisDayActivityForm = new ThisDayActivityForm();
            thisDayActivityForm.Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void seeEmployeeListButton_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            this.Hide();
            employeeListForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void salesWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.Show();
            this.Hide();
            saleForm.employeeNameLabel.Text = "Admin";
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
        }

        private void itemTypesButton_Click(object sender, EventArgs e)
        {
            ProductTypesForm productTypesForm = new ProductTypesForm();
            productTypesForm.Show();
        }

        private void postTypeButton_Click(object sender, EventArgs e)
        {
            PostTypesForm postTypesForm = new PostTypesForm();
            postTypesForm.Show();
        }
    }
}
