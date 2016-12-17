namespace Shop_Inventory_Management
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiaryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.lotNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductNames,
            this.ProductType,
            this.UnitPrice,
            this.UnitAvailable,
            this.LowRun,
            this.ReceiveDate,
            this.ExpiaryDate,
            this.LotNumber});
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 485);
            this.dataGridView1.TabIndex = 3;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            // 
            // ProductNames
            // 
            this.ProductNames.HeaderText = "Product Names";
            this.ProductNames.Name = "ProductNames";
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Product Type";
            this.ProductType.Name = "ProductType";
            this.ProductType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // UnitAvailable
            // 
            this.UnitAvailable.HeaderText = "Unit Available";
            this.UnitAvailable.Name = "UnitAvailable";
            // 
            // LowRun
            // 
            this.LowRun.HeaderText = "Low Run Limit";
            this.LowRun.Name = "LowRun";
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.HeaderText = "Receive Date";
            this.ReceiveDate.Name = "ReceiveDate";
            // 
            // ExpiaryDate
            // 
            this.ExpiaryDate.HeaderText = "Expiary Date";
            this.ExpiaryDate.Name = "ExpiaryDate";
            // 
            // LotNumber
            // 
            this.LotNumber.HeaderText = "Lot Nmber";
            this.LotNumber.Name = "LotNumber";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(975, 476);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 43);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(1077, 476);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(96, 42);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.accessToolStripMenuItem,
            this.employeeListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // accessToolStripMenuItem
            // 
            this.accessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminDashboardToolStripMenuItem,
            this.salesWindowToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            this.accessToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.accessToolStripMenuItem.Text = "Access";
            // 
            // adminDashboardToolStripMenuItem
            // 
            this.adminDashboardToolStripMenuItem.Name = "adminDashboardToolStripMenuItem";
            this.adminDashboardToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.adminDashboardToolStripMenuItem.Text = "Admin Dashboard";
            this.adminDashboardToolStripMenuItem.Click += new System.EventHandler(this.adminDashboardToolStripMenuItem_Click);
            // 
            // salesWindowToolStripMenuItem
            // 
            this.salesWindowToolStripMenuItem.Name = "salesWindowToolStripMenuItem";
            this.salesWindowToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salesWindowToolStripMenuItem.Text = "Sales Window";
            this.salesWindowToolStripMenuItem.Click += new System.EventHandler(this.salesWindowToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem});
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.employeeListToolStripMenuItem.Text = "Employee List";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.goToToolStripMenuItem.Text = "Go to";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.lotNumberTextBox);
            this.searchGroupBox.Controls.Add(this.label7);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.dateTimePicker2);
            this.searchGroupBox.Controls.Add(this.dateTimePicker1);
            this.searchGroupBox.Controls.Add(this.label6);
            this.searchGroupBox.Controls.Add(this.comboBox1);
            this.searchGroupBox.Controls.Add(this.label5);
            this.searchGroupBox.Controls.Add(this.label4);
            this.searchGroupBox.Controls.Add(this.textBox2);
            this.searchGroupBox.Controls.Add(this.label3);
            this.searchGroupBox.Controls.Add(this.textBox1);
            this.searchGroupBox.Controls.Add(this.label2);
            this.searchGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchGroupBox.Location = new System.Drawing.Point(956, 109);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(229, 258);
            this.searchGroupBox.TabIndex = 11;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // lotNumberTextBox
            // 
            this.lotNumberTextBox.Location = new System.Drawing.Point(93, 98);
            this.lotNumberTextBox.Name = "lotNumberTextBox";
            this.lotNumberTextBox.Size = new System.Drawing.Size(109, 20);
            this.lotNumberTextBox.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Lot Number :";
            // 
            // searchButton
            // 
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.Location = new System.Drawing.Point(106, 196);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 47);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 165);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Expiary Date :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Received Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Product Type :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product ID :";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1191, 531);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNames;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiaryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotNumber;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox lotNumberTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}