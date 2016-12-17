namespace Shop_Inventory_Management
{
    partial class PostTypesForm
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
            this.postTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.productTypeTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.postTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // postTypesDataGridView
            // 
            this.postTypesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductType});
            this.postTypesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.postTypesDataGridView.Name = "postTypesDataGridView";
            this.postTypesDataGridView.Size = new System.Drawing.Size(143, 253);
            this.postTypesDataGridView.TabIndex = 4;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Post Type";
            this.ProductType.Name = "ProductType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            // 
            // productTypeTextBox
            // 
            this.productTypeTextBox.Location = new System.Drawing.Point(167, 47);
            this.productTypeTextBox.Name = "productTypeTextBox";
            this.productTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.productTypeTextBox.TabIndex = 8;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(173, 198);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 47);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(173, 145);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 47);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(173, 92);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(94, 47);
            this.addNewButton.TabIndex = 7;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            // 
            // PostTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.postTypesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productTypeTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addNewButton);
            this.Name = "PostTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostTypesForm";
            ((System.ComponentModel.ISupportInitialize)(this.postTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView postTypesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productTypeTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
    }
}