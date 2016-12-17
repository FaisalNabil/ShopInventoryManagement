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
    public partial class ChangeAccountForm : Form
    {
        public ChangeAccountForm()
        {
            InitializeComponent();
            this.ActiveControl = employeeIdTextBox;
            passwordTextBox.PasswordChar = '*';
        }

        SaleForm saleForm = new SaleForm();
        AdminDashboard adminDashBoardForm = new AdminDashboard();

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox.Text == "100" && passwordTextBox.Text == "123")
            {
                saleForm.Show();
                this.Hide();
            }
            else if (employeeIdTextBox.Text == "111" && passwordTextBox.Text == "123")
            {
                adminDashBoardForm.Show();
                this.Hide();
            }
        }
    }
}
