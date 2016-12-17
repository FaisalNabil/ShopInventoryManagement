namespace Shop_Inventory_Management
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inventoryAccessLabel = new System.Windows.Forms.Label();
            this.addNewInventoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seeEmployeeListButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.seeInventoryListButton = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.thisDayActivityButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.itemTypeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.postTypeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryAccessLabel
            // 
            this.inventoryAccessLabel.AutoSize = true;
            this.inventoryAccessLabel.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAccessLabel.Location = new System.Drawing.Point(25, 42);
            this.inventoryAccessLabel.Name = "inventoryAccessLabel";
            this.inventoryAccessLabel.Size = new System.Drawing.Size(316, 25);
            this.inventoryAccessLabel.TabIndex = 2;
            this.inventoryAccessLabel.Text = "Inventory Access:";
            // 
            // addNewInventoryButton
            // 
            this.addNewInventoryButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewInventoryButton.Location = new System.Drawing.Point(219, 80);
            this.addNewInventoryButton.Name = "addNewInventoryButton";
            this.addNewInventoryButton.Size = new System.Drawing.Size(183, 56);
            this.addNewInventoryButton.TabIndex = 3;
            this.addNewInventoryButton.Text = "Add New";
            this.addNewInventoryButton.UseVisualStyleBackColor = true;
            this.addNewInventoryButton.Click += new System.EventHandler(this.addNewInventoryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personnel Access:";
            // 
            // seeEmployeeListButton
            // 
            this.seeEmployeeListButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeEmployeeListButton.Location = new System.Drawing.Point(30, 413);
            this.seeEmployeeListButton.Name = "seeEmployeeListButton";
            this.seeEmployeeListButton.Size = new System.Drawing.Size(183, 56);
            this.seeEmployeeListButton.TabIndex = 3;
            this.seeEmployeeListButton.Text = "See List";
            this.seeEmployeeListButton.UseVisualStyleBackColor = true;
            this.seeEmployeeListButton.Click += new System.EventHandler(this.seeEmployeeListButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.Location = new System.Drawing.Point(219, 413);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(183, 56);
            this.addEmployeeButton.TabIndex = 3;
            this.addEmployeeButton.Text = "Add New";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(571, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // seeInventoryListButton
            // 
            this.seeInventoryListButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeInventoryListButton.Location = new System.Drawing.Point(30, 80);
            this.seeInventoryListButton.Name = "seeInventoryListButton";
            this.seeInventoryListButton.Size = new System.Drawing.Size(183, 56);
            this.seeInventoryListButton.TabIndex = 3;
            this.seeInventoryListButton.Text = "See List";
            this.seeInventoryListButton.UseVisualStyleBackColor = true;
            this.seeInventoryListButton.Click += new System.EventHandler(this.seeInventoryListButton_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(571, 33);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 4;
            // 
            // thisDayActivityButton
            // 
            this.thisDayActivityButton.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisDayActivityButton.Location = new System.Drawing.Point(810, 39);
            this.thisDayActivityButton.Name = "thisDayActivityButton";
            this.thisDayActivityButton.Size = new System.Drawing.Size(145, 38);
            this.thisDayActivityButton.TabIndex = 3;
            this.thisDayActivityButton.Text = "This Day Activity";
            this.thisDayActivityButton.UseVisualStyleBackColor = true;
            this.thisDayActivityButton.Click += new System.EventHandler(this.thisDayActivityButton_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(571, 234);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(457, 245);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monthly Sales";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.accessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.salesWindowToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            this.accessToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.accessToolStripMenuItem.Text = "Access";
            // 
            // salesWindowToolStripMenuItem
            // 
            this.salesWindowToolStripMenuItem.Name = "salesWindowToolStripMenuItem";
            this.salesWindowToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.salesWindowToolStripMenuItem.Text = "Sales Window";
            this.salesWindowToolStripMenuItem.Click += new System.EventHandler(this.salesWindowToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type modification:";
            // 
            // itemTypeButton
            // 
            this.itemTypeButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeButton.Location = new System.Drawing.Point(219, 257);
            this.itemTypeButton.Name = "itemTypeButton";
            this.itemTypeButton.Size = new System.Drawing.Size(183, 56);
            this.itemTypeButton.TabIndex = 3;
            this.itemTypeButton.Text = "Item Types";
            this.itemTypeButton.UseVisualStyleBackColor = true;
            this.itemTypeButton.Click += new System.EventHandler(this.itemTypesButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monthly Sales";
            // 
            // postTypeButton
            // 
            this.postTypeButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTypeButton.Location = new System.Drawing.Point(30, 257);
            this.postTypeButton.Name = "postTypeButton";
            this.postTypeButton.Size = new System.Drawing.Size(183, 56);
            this.postTypeButton.TabIndex = 3;
            this.postTypeButton.Text = "Post Types";
            this.postTypeButton.UseVisualStyleBackColor = true;
            this.postTypeButton.Click += new System.EventHandler(this.postTypeButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1047, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.postTypeButton);
            this.Controls.Add(this.itemTypeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.addNewInventoryButton);
            this.Controls.Add(this.seeEmployeeListButton);
            this.Controls.Add(this.thisDayActivityButton);
            this.Controls.Add(this.seeInventoryListButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventoryAccessLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryAccessLabel;
        private System.Windows.Forms.Button addNewInventoryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seeEmployeeListButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button seeInventoryListButton;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button thisDayActivityButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button itemTypeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button postTypeButton;
    }
}