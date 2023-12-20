namespace C968_PA
{
    partial class ModifyPart
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
            this.InhouseRB = new System.Windows.Forms.RadioButton();
            this.OutsourcedRB = new System.Windows.Forms.RadioButton();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.InvTextbox = new System.Windows.Forms.TextBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.InOutTextbox = new System.Windows.Forms.TextBox();
            this.MaxTextbox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InvLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MinTextbox = new System.Windows.Forms.TextBox();
            this.InOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(2, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(88, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Modify Part";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // InhouseRB
            // 
            this.InhouseRB.AutoSize = true;
            this.InhouseRB.Location = new System.Drawing.Point(186, 72);
            this.InhouseRB.Name = "InhouseRB";
            this.InhouseRB.Size = new System.Drawing.Size(100, 24);
            this.InhouseRB.TabIndex = 1;
            this.InhouseRB.TabStop = true;
            this.InhouseRB.Text = "In-House";
            this.InhouseRB.UseVisualStyleBackColor = true;
            this.InhouseRB.CheckedChanged += new System.EventHandler(this.InhouseRB_CheckedChanged);
            // 
            // OutsourcedRB
            // 
            this.OutsourcedRB.AutoSize = true;
            this.OutsourcedRB.Location = new System.Drawing.Point(415, 72);
            this.OutsourcedRB.Name = "OutsourcedRB";
            this.OutsourcedRB.Size = new System.Drawing.Size(117, 24);
            this.OutsourcedRB.TabIndex = 2;
            this.OutsourcedRB.TabStop = true;
            this.OutsourcedRB.Text = "Outsourced";
            this.OutsourcedRB.UseVisualStyleBackColor = true;
            this.OutsourcedRB.CheckedChanged += new System.EventHandler(this.OutsourcedRB_CheckedChanged);
            // 
            // IDtextbox
            // 
            this.IDtextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.IDtextbox.Location = new System.Drawing.Point(326, 137);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.ReadOnly = true;
            this.IDtextbox.Size = new System.Drawing.Size(100, 26);
            this.IDtextbox.TabIndex = 3;
            this.IDtextbox.TextChanged += new System.EventHandler(this.IDtextbox_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(326, 169);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 26);
            this.NameTextbox.TabIndex = 4;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // InvTextbox
            // 
            this.InvTextbox.Location = new System.Drawing.Point(326, 201);
            this.InvTextbox.Name = "InvTextbox";
            this.InvTextbox.Size = new System.Drawing.Size(100, 26);
            this.InvTextbox.TabIndex = 5;
            this.InvTextbox.TextChanged += new System.EventHandler(this.InvTextbox_TextChanged);
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(326, 245);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(100, 26);
            this.PriceTextbox.TabIndex = 6;
            this.PriceTextbox.TextChanged += new System.EventHandler(this.PriceTextbox_TextChanged);
            // 
            // InOutTextbox
            // 
            this.InOutTextbox.Location = new System.Drawing.Point(324, 335);
            this.InOutTextbox.Name = "InOutTextbox";
            this.InOutTextbox.Size = new System.Drawing.Size(134, 26);
            this.InOutTextbox.TabIndex = 7;
            this.InOutTextbox.TextChanged += new System.EventHandler(this.InOutTextbox_TextChanged);
            // 
            // MaxTextbox
            // 
            this.MaxTextbox.Location = new System.Drawing.Point(326, 303);
            this.MaxTextbox.Name = "MaxTextbox";
            this.MaxTextbox.Size = new System.Drawing.Size(60, 26);
            this.MaxTextbox.TabIndex = 8;
            this.MaxTextbox.TextChanged += new System.EventHandler(this.MaxTextbox_TextChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(235, 130);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(235, 175);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // InvLabel
            // 
            this.InvLabel.AutoSize = true;
            this.InvLabel.Location = new System.Drawing.Point(235, 204);
            this.InvLabel.Name = "InvLabel";
            this.InvLabel.Size = new System.Drawing.Size(74, 20);
            this.InvLabel.TabIndex = 11;
            this.InvLabel.Text = "Inventory";
            this.InvLabel.Click += new System.EventHandler(this.InvLabel_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(235, 251);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(235, 303);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(38, 20);
            this.MaxLabel.TabIndex = 13;
            this.MaxLabel.Text = "Max";
            this.MaxLabel.Click += new System.EventHandler(this.MaxLabel_Click);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(415, 306);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(34, 20);
            this.MinLabel.TabIndex = 14;
            this.MinLabel.Text = "Min";
            this.MinLabel.Click += new System.EventHandler(this.MinLabel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(586, 394);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 44);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MinTextbox
            // 
            this.MinTextbox.Location = new System.Drawing.Point(472, 306);
            this.MinTextbox.Name = "MinTextbox";
            this.MinTextbox.Size = new System.Drawing.Size(60, 26);
            this.MinTextbox.TabIndex = 17;
            this.MinTextbox.TextChanged += new System.EventHandler(this.MinTextbox_TextChanged);
            // 
            // InOutLabel
            // 
            this.InOutLabel.AutoSize = true;
            this.InOutLabel.Location = new System.Drawing.Point(189, 341);
            this.InOutLabel.Name = "InOutLabel";
            this.InOutLabel.Size = new System.Drawing.Size(90, 20);
            this.InOutLabel.TabIndex = 18;
            this.InOutLabel.Text = "Machine ID";
            this.InOutLabel.Click += new System.EventHandler(this.InOutLabel_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InOutLabel);
            this.Controls.Add(this.MinTextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InvLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.MaxTextbox);
            this.Controls.Add(this.InOutTextbox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.InvTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.IDtextbox);
            this.Controls.Add(this.OutsourcedRB);
            this.Controls.Add(this.InhouseRB);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RadioButton InhouseRB;
        private System.Windows.Forms.RadioButton OutsourcedRB;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox InvTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.TextBox InOutTextbox;
        private System.Windows.Forms.TextBox MaxTextbox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InvLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox MinTextbox;
        private System.Windows.Forms.Label InOutLabel;
    }
}