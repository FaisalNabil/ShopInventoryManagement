namespace Shop_Inventory_Management
{
    partial class EmployeeListForm
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
            this.salesWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.joinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesWindowToolStripMenuItem
            // 
            this.salesWindowToolStripMenuItem.Name = "salesWindowToolStripMenuItem";
            this.salesWindowToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salesWindowToolStripMenuItem.Text = "Sales Window";
            this.salesWindowToolStripMenuItem.Click += new System.EventHandler(this.salesWindowToolStripMenuItem_Click);
            // 
            // accessToolStripMenuItem
            // 
            this.accessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesWindowToolStripMenuItem,
            this.adminDashboardToolStripMenuItem,
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
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.accessToolStripMenuItem,
            this.inventoryListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryListToolStripMenuItem
            // 
            this.inventoryListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem});
            this.inventoryListToolStripMenuItem.Name = "inventoryListToolStripMenuItem";
            this.inventoryListToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.inventoryListToolStripMenuItem.Text = "Inventory List";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.goToToolStripMenuItem.Text = "Go to";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(967, 373);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(96, 42);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(856, 373);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 43);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.Salary,
            this.JoinDate,
            this.BirthDate,
            this.Post,
            this.Phone});
            this.dataGridView1.Location = new System.Drawing.Point(4, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 485);
            this.dataGridView1.TabIndex = 12;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.Name = "EmployeeId";
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // JoinDate
            // 
            this.JoinDate.HeaderText = "Join Date";
            this.JoinDate.Name = "JoinDate";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.Name = "BirthDate";
            // 
            // Post
            // 
            this.Post.HeaderText = "Post";
            this.Post.Name = "Post";
            this.Post.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Post.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.birthDateTimePicker);
            this.searchGroupBox.Controls.Add(this.joinDateTimePicker);
            this.searchGroupBox.Controls.Add(this.label6);
            this.searchGroupBox.Controls.Add(this.postComboBox);
            this.searchGroupBox.Controls.Add(this.label5);
            this.searchGroupBox.Controls.Add(this.label4);
            this.searchGroupBox.Controls.Add(this.employeeNameTextBox);
            this.searchGroupBox.Controls.Add(this.label3);
            this.searchGroupBox.Controls.Add(this.label2);
            this.searchGroupBox.Controls.Add(this.employeeIdTextBox);
            this.searchGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchGroupBox.Location = new System.Drawing.Point(760, 97);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(302, 249);
            this.searchGroupBox.TabIndex = 27;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.Location = new System.Drawing.Point(190, 180);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 47);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(101, 141);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateTimePicker.TabIndex = 36;
            // 
            // joinDateTimePicker
            // 
            this.joinDateTimePicker.Location = new System.Drawing.Point(101, 115);
            this.joinDateTimePicker.Name = "joinDateTimePicker";
            this.joinDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.joinDateTimePicker.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Birth Date :";
            // 
            // postComboBox
            // 
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Location = new System.Drawing.Point(92, 88);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(113, 21);
            this.postComboBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Join Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Post :";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(96, 63);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(109, 20);
            this.employeeNameTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Employee Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Employee ID :";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(88, 37);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(117, 20);
            this.employeeIdTextBox.TabIndex = 34;
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1082, 528);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeListForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem salesWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem adminDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.DateTimePicker joinDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox postComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeIdTextBox;
    }
}