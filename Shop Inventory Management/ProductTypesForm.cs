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
    public partial class ProductTypesForm : Form
    {
        public ProductTypesForm()
        {
            InitializeComponent();
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "EditEmployee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //this.Hide();
                MessageBox.Show("0 rows deleted");
            };
        }
    }
}
