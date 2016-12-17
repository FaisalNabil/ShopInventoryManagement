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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            this.ActiveControl = currentPasswordTextBox;
            currentPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.PasswordChar = '*';
            confirmNewPasswordTextBox.PasswordChar = '*';
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "ChangePassword", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
            
            
        }
    }
}
