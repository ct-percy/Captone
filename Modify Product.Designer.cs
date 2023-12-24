namespace IMSLocal
{
    partial class ModifyProduct
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AllPartsLabel = new System.Windows.Forms.Label();
            this.AllPartsDGV = new System.Windows.Forms.DataGridView();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.AssociatedPartsLabel = new System.Windows.Forms.Label();
            this.AssociatedPartsDGV = new System.Windows.Forms.DataGridView();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.InvTextbox = new System.Windows.Forms.TextBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InvLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(13, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(114, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Modify Product";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(779, 61);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(252, 26);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(669, 43);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(97, 44);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AllPartsLabel
            // 
            this.AllPartsLabel.AutoSize = true;
            this.AllPartsLabel.Location = new System.Drawing.Point(515, 67);
            this.AllPartsLabel.Name = "AllPartsLabel";
            this.AllPartsLabel.Size = new System.Drawing.Size(67, 20);
            this.AllPartsLabel.TabIndex = 3;
            this.AllPartsLabel.Text = "All Parts";
            this.AllPartsLabel.Click += new System.EventHandler(this.AllPartsLabel_Click);
            // 
            // AllPartsDGV
            // 
            this.AllPartsDGV.AllowUserToAddRows = false;
            this.AllPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsDGV.Location = new System.Drawing.Point(509, 103);
            this.AllPartsDGV.MultiSelect = false;
            this.AllPartsDGV.Name = "AllPartsDGV";
            this.AllPartsDGV.ReadOnly = true;
            this.AllPartsDGV.RowHeadersWidth = 62;
            this.AllPartsDGV.RowTemplate.Height = 28;
            this.AllPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPartsDGV.Size = new System.Drawing.Size(524, 197);
            this.AllPartsDGV.TabIndex = 4;
            this.AllPartsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPartsDGV_CellContentClick);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(936, 306);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(97, 44);
            this.AddPartButton.TabIndex = 5;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // AssociatedPartsLabel
            // 
            this.AssociatedPartsLabel.AutoSize = true;
            this.AssociatedPartsLabel.Location = new System.Drawing.Point(505, 341);
            this.AssociatedPartsLabel.Name = "AssociatedPartsLabel";
            this.AssociatedPartsLabel.Size = new System.Drawing.Size(129, 20);
            this.AssociatedPartsLabel.TabIndex = 6;
            this.AssociatedPartsLabel.Text = "Associated Parts";
            this.AssociatedPartsLabel.Click += new System.EventHandler(this.AssociatedPartsLabel_Click);
            // 
            // AssociatedPartsDGV
            // 
            this.AssociatedPartsDGV.AllowUserToAddRows = false;
            this.AssociatedPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsDGV.Location = new System.Drawing.Point(509, 377);
            this.AssociatedPartsDGV.MultiSelect = false;
            this.AssociatedPartsDGV.Name = "AssociatedPartsDGV";
            this.AssociatedPartsDGV.ReadOnly = true;
            this.AssociatedPartsDGV.RowHeadersWidth = 62;
            this.AssociatedPartsDGV.RowTemplate.Height = 28;
            this.AssociatedPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsDGV.Size = new System.Drawing.Size(525, 196);
            this.AssociatedPartsDGV.TabIndex = 7;
            this.AssociatedPartsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDGV_CellContentClick);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(937, 579);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(97, 44);
            this.DeletePartButton.TabIndex = 8;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.CancelButton.Location = new System.Drawing.Point(945, 629);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 44);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(837, 629);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(97, 44);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IDTextbox
            // 
            this.IDTextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.IDTextbox.Location = new System.Drawing.Point(177, 215);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.ReadOnly = true;
            this.IDTextbox.Size = new System.Drawing.Size(100, 26);
            this.IDTextbox.TabIndex = 11;
            this.IDTextbox.TextChanged += new System.EventHandler(this.IDTextbox_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(177, 264);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 26);
            this.NameTextbox.TabIndex = 12;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // InvTextbox
            // 
            this.InvTextbox.Location = new System.Drawing.Point(177, 309);
            this.InvTextbox.Name = "InvTextbox";
            this.InvTextbox.Size = new System.Drawing.Size(100, 26);
            this.InvTextbox.TabIndex = 13;
            this.InvTextbox.TextChanged += new System.EventHandler(this.InvTextbox_TextChanged);
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(177, 355);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(100, 26);
            this.PriceTextbox.TabIndex = 14;
            this.PriceTextbox.TextChanged += new System.EventHandler(this.PriceTextbox_TextChanged);
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.Location = new System.Drawing.Point(139, 403);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(100, 26);
            this.MaxTextbox.TabIndex = 15;
            this.MaxTextbox.TextChanged += new System.EventHandler(this.MaxTextbox_TextChanged);
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(327, 406);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(100, 26);
            this.MinTextbox.TabIndex = 16;
            this.MinTextbox.TextChanged += new System.EventHandler(this.MinTextbox_TextChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(70, 220);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 17;
            this.IDLabel.Text = "ID";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(74, 270);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // InvLabel
            // 
            this.InvLabel.AutoSize = true;
            this.InvLabel.Location = new System.Drawing.Point(74, 316);
            this.InvLabel.Name = "InvLabel";
            this.InvLabel.Size = new System.Drawing.Size(74, 20);
            this.InvLabel.TabIndex = 19;
            this.InvLabel.Text = "Inventory";
            this.InvLabel.Click += new System.EventHandler(this.InvLabel_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(78, 360);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 20;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(70, 403);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(38, 20);
            this.MaxLabel.TabIndex = 21;
            this.MaxLabel.Text = "Max";
            this.MaxLabel.Click += new System.EventHandler(this.MaxLabel_Click);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(271, 408);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(34, 20);
            this.MinLabel.TabIndex = 22;
            this.MinLabel.Text = "Min";
            this.MinLabel.Click += new System.EventHandler(this.MinLabel_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 688);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InvLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.MinTextbox);
            this.Controls.Add(this.MaxTextbox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.InvTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.AssociatedPartsDGV);
            this.Controls.Add(this.AssociatedPartsLabel);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.AllPartsDGV);
            this.Controls.Add(this.AllPartsLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label AllPartsLabel;
        private System.Windows.Forms.DataGridView AllPartsDGV;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Label AssociatedPartsLabel;
        private System.Windows.Forms.DataGridView AssociatedPartsDGV;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox InvTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InvLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
    }
}