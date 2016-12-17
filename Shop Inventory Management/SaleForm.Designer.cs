namespace Shop_Inventory_Management
{
    partial class SaleForm
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInFromAnotherAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToAdminDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productListView = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.productTypeTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitsAvailableVariableLabel = new System.Windows.Forms.Label();
            this.UnitPriceVariableLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.ProductTypeVariableLabel = new System.Windows.Forms.Label();
            this.ProductTypeLabel = new System.Windows.Forms.Label();
            this.ProductNameVariableLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.AddedProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.productDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddedProductName,
            this.Units,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(678, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 344);
            this.dataGridView1.TabIndex = 5;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(866, 455);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 38);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(947, 455);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 38);
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.accessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 19;
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
            this.logInFromAnotherAccountToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.backToAdminDashboardToolStripMenuItem});
            this.accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            this.accessToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.accessToolStripMenuItem.Text = "Access";
            // 
            // logInFromAnotherAccountToolStripMenuItem
            // 
            this.logInFromAnotherAccountToolStripMenuItem.Name = "logInFromAnotherAccountToolStripMenuItem";
            this.logInFromAnotherAccountToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.logInFromAnotherAccountToolStripMenuItem.Text = "Log In From another account";
            this.logInFromAnotherAccountToolStripMenuItem.Click += new System.EventHandler(this.logInFromAnotherAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // backToAdminDashboardToolStripMenuItem
            // 
            this.backToAdminDashboardToolStripMenuItem.Name = "backToAdminDashboardToolStripMenuItem";
            this.backToAdminDashboardToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.backToAdminDashboardToolStripMenuItem.Text = "Back to Admin dashboard";
            this.backToAdminDashboardToolStripMenuItem.Click += new System.EventHandler(this.backToAdminDashboardToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(884, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(810, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Employee Name:";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.Location = new System.Drawing.Point(947, 42);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(49, 16);
            this.employeeNameLabel.TabIndex = 22;
            this.employeeNameLabel.Text = "Tuhin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productListView);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.productTypeTextBox);
            this.groupBox1.Controls.Add(this.productIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 399);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available List";
            // 
            // productListView
            // 
            this.productListView.Location = new System.Drawing.Point(6, 120);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(264, 273);
            this.productListView.TabIndex = 31;
            this.productListView.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Product Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Product Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Product ID :";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(326, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // productTypeTextBox
            // 
            this.productTypeTextBox.Location = new System.Drawing.Point(280, 23);
            this.productTypeTextBox.Name = "productTypeTextBox";
            this.productTypeTextBox.Size = new System.Drawing.Size(121, 20);
            this.productTypeTextBox.TabIndex = 24;
            this.productTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(77, 23);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(110, 20);
            this.productIdTextBox.TabIndex = 25;
            this.productIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productDetailsGroupBox
            // 
            this.productDetailsGroupBox.Controls.Add(this.label6);
            this.productDetailsGroupBox.Controls.Add(this.UnitsAvailableVariableLabel);
            this.productDetailsGroupBox.Controls.Add(this.UnitPriceVariableLabel);
            this.productDetailsGroupBox.Controls.Add(this.UnitPriceLabel);
            this.productDetailsGroupBox.Controls.Add(this.ProductTypeVariableLabel);
            this.productDetailsGroupBox.Controls.Add(this.ProductTypeLabel);
            this.productDetailsGroupBox.Controls.Add(this.ProductNameVariableLabel);
            this.productDetailsGroupBox.Controls.Add(this.productNameLabel);
            this.productDetailsGroupBox.Location = new System.Drawing.Point(459, 56);
            this.productDetailsGroupBox.Name = "productDetailsGroupBox";
            this.productDetailsGroupBox.Size = new System.Drawing.Size(212, 177);
            this.productDetailsGroupBox.TabIndex = 24;
            this.productDetailsGroupBox.TabStop = false;
            this.productDetailsGroupBox.Text = "Product Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "20";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UnitsAvailableVariableLabel
            // 
            this.UnitsAvailableVariableLabel.AutoSize = true;
            this.UnitsAvailableVariableLabel.Location = new System.Drawing.Point(13, 119);
            this.UnitsAvailableVariableLabel.Name = "UnitsAvailableVariableLabel";
            this.UnitsAvailableVariableLabel.Size = new System.Drawing.Size(83, 13);
            this.UnitsAvailableVariableLabel.TabIndex = 4;
            this.UnitsAvailableVariableLabel.Text = "Units Available :";
            // 
            // UnitPriceVariableLabel
            // 
            this.UnitPriceVariableLabel.AutoSize = true;
            this.UnitPriceVariableLabel.Location = new System.Drawing.Point(121, 94);
            this.UnitPriceVariableLabel.Name = "UnitPriceVariableLabel";
            this.UnitPriceVariableLabel.Size = new System.Drawing.Size(13, 13);
            this.UnitPriceVariableLabel.TabIndex = 9;
            this.UnitPriceVariableLabel.Text = "6";
            this.UnitPriceVariableLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(13, 94);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(59, 13);
            this.UnitPriceLabel.TabIndex = 5;
            this.UnitPriceLabel.Text = "Unit Price :";
            // 
            // ProductTypeVariableLabel
            // 
            this.ProductTypeVariableLabel.AutoSize = true;
            this.ProductTypeVariableLabel.Location = new System.Drawing.Point(121, 67);
            this.ProductTypeVariableLabel.Name = "ProductTypeVariableLabel";
            this.ProductTypeVariableLabel.Size = new System.Drawing.Size(26, 13);
            this.ProductTypeVariableLabel.TabIndex = 10;
            this.ProductTypeVariableLabel.Text = "Pen";
            this.ProductTypeVariableLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProductTypeLabel
            // 
            this.ProductTypeLabel.AutoSize = true;
            this.ProductTypeLabel.Location = new System.Drawing.Point(13, 67);
            this.ProductTypeLabel.Name = "ProductTypeLabel";
            this.ProductTypeLabel.Size = new System.Drawing.Size(77, 13);
            this.ProductTypeLabel.TabIndex = 6;
            this.ProductTypeLabel.Text = "Product Type :";
            // 
            // ProductNameVariableLabel
            // 
            this.ProductNameVariableLabel.AutoSize = true;
            this.ProductNameVariableLabel.Location = new System.Drawing.Point(121, 45);
            this.ProductNameVariableLabel.Name = "ProductNameVariableLabel";
            this.ProductNameVariableLabel.Size = new System.Drawing.Size(79, 13);
            this.ProductNameVariableLabel.TabIndex = 11;
            this.ProductNameVariableLabel.Text = "Matador Alltime";
            this.ProductNameVariableLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(13, 45);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(81, 13);
            this.productNameLabel.TabIndex = 7;
            this.productNameLabel.Text = "Product Name :";
            // 
            // AddedProductName
            // 
            this.AddedProductName.HeaderText = "Product Name";
            this.AddedProductName.Name = "AddedProductName";
            this.AddedProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1029, 505);
            this.Controls.Add(this.productDetailsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.productDetailsGroupBox.ResumeLayout(false);
            this.productDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInFromAnotherAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem backToAdminDashboardToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox productTypeTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.GroupBox productDetailsGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UnitsAvailableVariableLabel;
        private System.Windows.Forms.Label UnitPriceVariableLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label ProductTypeVariableLabel;
        private System.Windows.Forms.Label ProductTypeLabel;
        private System.Windows.Forms.Label ProductNameVariableLabel;
        private System.Windows.Forms.Label productNameLabel;
    }
}