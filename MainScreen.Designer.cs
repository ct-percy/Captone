namespace C968_PA
{
    partial class MainScreen
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
            this.SearchPartsButton = new System.Windows.Forms.Button();
            this.IMSLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.PartSearchBox = new System.Windows.Forms.TextBox();
            this.PartsDGV = new System.Windows.Forms.DataGridView();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.SearchProductsButton = new System.Windows.Forms.Button();
            this.ProductsSearchBox = new System.Windows.Forms.TextBox();
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.reportsComboBox = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Location = new System.Drawing.Point(226, 86);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(97, 38);
            this.SearchPartsButton.TabIndex = 1;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // IMSLabel
            // 
            this.IMSLabel.AutoSize = true;
            this.IMSLabel.Location = new System.Drawing.Point(13, 13);
            this.IMSLabel.Name = "IMSLabel";
            this.IMSLabel.Size = new System.Drawing.Size(229, 20);
            this.IMSLabel.TabIndex = 2;
            this.IMSLabel.Text = "Inventory Management System";
            this.IMSLabel.Click += new System.EventHandler(this.IMSLabel_Click);
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Location = new System.Drawing.Point(20, 131);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(46, 20);
            this.PartsLabel.TabIndex = 3;
            this.PartsLabel.Text = "Parts";
            this.PartsLabel.Click += new System.EventHandler(this.PartsLabel_Click);
            // 
            // PartSearchBox
            // 
            this.PartSearchBox.Location = new System.Drawing.Point(336, 98);
            this.PartSearchBox.Name = "PartSearchBox";
            this.PartSearchBox.Size = new System.Drawing.Size(168, 26);
            this.PartSearchBox.TabIndex = 4;
            this.PartSearchBox.TextChanged += new System.EventHandler(this.PartSearchBox_TextChanged);
            // 
            // PartsDGV
            // 
            this.PartsDGV.AllowUserToAddRows = false;
            this.PartsDGV.AllowUserToDeleteRows = false;
            this.PartsDGV.AllowUserToResizeColumns = false;
            this.PartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDGV.Location = new System.Drawing.Point(24, 155);
            this.PartsDGV.Name = "PartsDGV";
            this.PartsDGV.ReadOnly = true;
            this.PartsDGV.RowHeadersWidth = 62;
            this.PartsDGV.RowTemplate.Height = 28;
            this.PartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDGV.Size = new System.Drawing.Size(480, 248);
            this.PartsDGV.TabIndex = 5;
            this.PartsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDGV_CellContentClick);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(205, 422);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(96, 34);
            this.AddPartButton.TabIndex = 6;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Location = new System.Drawing.Point(304, 422);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(96, 34);
            this.ModifyPartButton.TabIndex = 7;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(399, 422);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(96, 34);
            this.DeletePartButton.TabIndex = 8;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Location = new System.Drawing.Point(576, 131);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(72, 20);
            this.ProductsLabel.TabIndex = 9;
            this.ProductsLabel.Text = "Products";
            // 
            // SearchProductsButton
            // 
            this.SearchProductsButton.Location = new System.Drawing.Point(758, 86);
            this.SearchProductsButton.Name = "SearchProductsButton";
            this.SearchProductsButton.Size = new System.Drawing.Size(97, 38);
            this.SearchProductsButton.TabIndex = 10;
            this.SearchProductsButton.Text = "Search";
            this.SearchProductsButton.UseVisualStyleBackColor = true;
            this.SearchProductsButton.Click += new System.EventHandler(this.SearchProductsButton_Click);
            // 
            // ProductsSearchBox
            // 
            this.ProductsSearchBox.Location = new System.Drawing.Point(861, 94);
            this.ProductsSearchBox.Name = "ProductsSearchBox";
            this.ProductsSearchBox.Size = new System.Drawing.Size(168, 26);
            this.ProductsSearchBox.TabIndex = 11;
            this.ProductsSearchBox.TextChanged += new System.EventHandler(this.ProductsSearchBox_TextChanged);
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AllowUserToAddRows = false;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDGV.Location = new System.Drawing.Point(580, 155);
            this.ProductsDGV.MultiSelect = false;
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.ReadOnly = true;
            this.ProductsDGV.RowHeadersWidth = 62;
            this.ProductsDGV.RowTemplate.Height = 28;
            this.ProductsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDGV.Size = new System.Drawing.Size(480, 248);
            this.ProductsDGV.TabIndex = 12;
            this.ProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDGV_CellContentClick);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(789, 422);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(96, 34);
            this.AddProductButton.TabIndex = 13;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Location = new System.Drawing.Point(870, 422);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(96, 34);
            this.ModifyProductButton.TabIndex = 14;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(954, 422);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(96, 34);
            this.DeleteProductButton.TabIndex = 15;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(964, 584);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 34);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Items.AddRange(new object[] {
            "All Parts",
            "All Inhouse Parts",
            "All Outsourced Parts",
            "All Products",
            "All Associated Parts"});
            this.reportsComboBox.Location = new System.Drawing.Point(12, 584);
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(185, 28);
            this.reportsComboBox.TabIndex = 17;
            this.reportsComboBox.Text = "Reports";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(227, 580);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(96, 34);
            this.generateButton.TabIndex = 18;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 640);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.reportsComboBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductsDGV);
            this.Controls.Add(this.ProductsSearchBox);
            this.Controls.Add(this.SearchProductsButton);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.PartsDGV);
            this.Controls.Add(this.PartSearchBox);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.IMSLabel);
            this.Controls.Add(this.SearchPartsButton);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.Label IMSLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.TextBox PartSearchBox;
        private System.Windows.Forms.DataGridView PartsDGV;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button SearchProductsButton;
        private System.Windows.Forms.TextBox ProductsSearchBox;
        private System.Windows.Forms.DataGridView ProductsDGV;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.Button generateButton;
    }
}