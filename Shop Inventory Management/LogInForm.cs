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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            this.ActiveControl=employeeIdTextBox;
            passwordTextBox.PasswordChar = '*';
        }

        SaleForm saleForm = new SaleForm();
        AdminDashboard adminDashBoardForm = new AdminDashboard();

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            if (employeeIdTextBox.Text == "100" && passwordTextBox.Text == "123")
            {
                saleForm.Show();
                this.Hide();
                saleForm.employeeNameLabel.Text = "Tuhin";
            }
            else if (employeeIdTextBox.Text == "111" && passwordTextBox.Text == "123")
            {
                adminDashBoardForm.Show();
                this.Hide();
            }
            else
            {
                employeeIdTextBox.Clear();
                passwordTextBox.Clear();
                MessageBox.Show("Please enter a valid combination of ID and Password");
            }
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
