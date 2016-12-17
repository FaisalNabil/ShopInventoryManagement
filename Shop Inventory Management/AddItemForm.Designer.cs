namespace Shop_Inventory_Management
{
    partial class AddItemForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.ProdctTypeLabel = new System.Windows.Forms.Label();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalUnitsLabel = new System.Windows.Forms.Label();
            this.totalUnitsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.lowRunCheckBox = new System.Windows.Forms.CheckBox();
            this.lowRunTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.receiveDateLabel = new System.Windows.Forms.Label();
            this.recieveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.expiaryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lotNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(12, 20);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(78, 13);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(97, 17);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.productNameTextBox.TabIndex = 1;
            // 
            // ProdctTypeLabel
            // 
            this.ProdctTypeLabel.AutoSize = true;
            this.ProdctTypeLabel.Location = new System.Drawing.Point(12, 56);
            this.ProdctTypeLabel.Name = "ProdctTypeLabel";
            this.ProdctTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.ProdctTypeLabel.TabIndex = 0;
            this.ProdctTypeLabel.Text = "Product Type:";
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Items.AddRange(new object[] {
            "Meat",
            "Fish",
            "Biscuit",
            "Candy",
            "Oil"});
            this.productTypeComboBox.Location = new System.Drawing.Point(97, 56);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(96, 21);
            this.productTypeComboBox.TabIndex = 2;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(245, 59);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(56, 13);
            this.UnitPriceLabel.TabIndex = 0;
            this.UnitPriceLabel.Text = "Unit Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(311, 59);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(119, 20);
            this.unitPriceTextBox.TabIndex = 3;
            // 
            // totalUnitsLabel
            // 
            this.totalUnitsLabel.AutoSize = true;
            this.totalUnitsLabel.Location = new System.Drawing.Point(12, 101);
            this.totalUnitsLabel.Name = "totalUnitsLabel";
            this.totalUnitsLabel.Size = new System.Drawing.Size(61, 13);
            this.totalUnitsLabel.TabIndex = 0;
            this.totalUnitsLabel.Text = "Total Units:";
            // 
            // totalUnitsTextBox
            // 
            this.totalUnitsTextBox.Location = new System.Drawing.Point(97, 101);
            this.totalUnitsTextBox.Name = "totalUnitsTextBox";
            this.totalUnitsTextBox.Size = new System.Drawing.Size(123, 20);
            this.totalUnitsTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(307, 20);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(123, 20);
            this.productIdTextBox.TabIndex = 1;
            // 
            // lowRunCheckBox
            // 
            this.lowRunCheckBox.AutoSize = true;
            this.lowRunCheckBox.Location = new System.Drawing.Point(368, 100);
            this.lowRunCheckBox.Name = "lowRunCheckBox";
            this.lowRunCheckBox.Size = new System.Drawing.Size(151, 17);
            this.lowRunCheckBox.TabIndex = 5;
            this.lowRunCheckBox.Text = "Notify When Running Low";
            this.lowRunCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowRunTextBox
            // 
            this.lowRunTextBox.Location = new System.Drawing.Point(368, 123);
            this.lowRunTextBox.Name = "lowRunTextBox";
            this.lowRunTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowRunTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(626, 123);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // receiveDateLabel
            // 
            this.receiveDateLabel.AutoSize = true;
            this.receiveDateLabel.Location = new System.Drawing.Point(484, 26);
            this.receiveDateLabel.Name = "receiveDateLabel";
            this.receiveDateLabel.Size = new System.Drawing.Size(79, 13);
            this.receiveDateLabel.TabIndex = 8;
            this.receiveDateLabel.Text = "Recieve Date :";
            // 
            // recieveDateTimePicker
            // 
            this.recieveDateTimePicker.Location = new System.Drawing.Point(570, 26);
            this.recieveDateTimePicker.Name = "recieveDateTimePicker";
            this.recieveDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.recieveDateTimePicker.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Expiary Date :";
            // 
            // expiaryDateTimePicker
            // 
            this.expiaryDateTimePicker.Location = new System.Drawing.Point(570, 56);
            this.expiaryDateTimePicker.Name = "expiaryDateTimePicker";
            this.expiaryDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.expiaryDateTimePicker.TabIndex = 9;
            // 
            // lotNumberTextBox
            // 
            this.lotNumberTextBox.Location = new System.Drawing.Point(97, 126);
            this.lotNumberTextBox.Name = "lotNumberTextBox";
            this.lotNumberTextBox.Size = new System.Drawing.Size(123, 20);
            this.lotNumberTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lot Number :";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(741, 175);
            this.Controls.Add(this.lotNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expiaryDateTimePicker);
            this.Controls.Add(this.recieveDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receiveDateLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lowRunTextBox);
            this.Controls.Add(this.lowRunCheckBox);
            this.Controls.Add(this.totalUnitsTextBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.productTypeComboBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.totalUnitsLabel);
            this.Controls.Add(this.ProdctTypeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameLabel);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label ProdctTypeLabel;
        private System.Windows.Forms.ComboBox productTypeComboBox;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label totalUnitsLabel;
        private System.Windows.Forms.TextBox totalUnitsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.CheckBox lowRunCheckBox;
        private System.Windows.Forms.TextBox lowRunTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label receiveDateLabel;
        private System.Windows.Forms.DateTimePicker recieveDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker expiaryDateTimePicker;
        private System.Windows.Forms.TextBox lotNumberTextBox;
        private System.Windows.Forms.Label label3;
    }
}