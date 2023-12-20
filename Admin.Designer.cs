namespace C968_PA
{
    partial class Admin
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
            this.employeeIDTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.userRB = new System.Windows.Forms.RadioButton();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.employeesDGV = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminUsername = new System.Windows.Forms.TextBox();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDTextbox
            // 
            this.employeeIDTextbox.Location = new System.Drawing.Point(158, 133);
            this.employeeIDTextbox.Name = "employeeIDTextbox";
            this.employeeIDTextbox.Size = new System.Drawing.Size(97, 26);
            this.employeeIDTextbox.TabIndex = 0;
            this.employeeIDTextbox.TextChanged += new System.EventHandler(this.employeeIDTextbox_TextChanged);
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(130, 189);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(171, 26);
            this.firstNameTextbox.TabIndex = 1;
            this.firstNameTextbox.TextChanged += new System.EventHandler(this.firstNameTextbox_TextChanged);
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(130, 241);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(171, 26);
            this.lastNameTextbox.TabIndex = 2;
            this.lastNameTextbox.TextChanged += new System.EventHandler(this.lastNameTextbox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(130, 300);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(171, 26);
            this.usernameTextbox.TabIndex = 3;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(130, 356);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(171, 26);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // userRB
            // 
            this.userRB.AutoSize = true;
            this.userRB.Location = new System.Drawing.Point(53, 425);
            this.userRB.Name = "userRB";
            this.userRB.Size = new System.Drawing.Size(68, 24);
            this.userRB.TabIndex = 5;
            this.userRB.TabStop = true;
            this.userRB.Text = "User";
            this.userRB.UseVisualStyleBackColor = true;
            this.userRB.CheckedChanged += new System.EventHandler(this.userRB_CheckedChanged);
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.Location = new System.Drawing.Point(246, 425);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(128, 24);
            this.adminRB.TabIndex = 6;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Administrator";
            this.adminRB.UseVisualStyleBackColor = true;
            this.adminRB.CheckedChanged += new System.EventHandler(this.adminRB_CheckedChanged);
            // 
            // employeesDGV
            // 
            this.employeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDGV.Location = new System.Drawing.Point(532, 180);
            this.employeesDGV.Name = "employeesDGV";
            this.employeesDGV.ReadOnly = true;
            this.employeesDGV.RowHeadersWidth = 62;
            this.employeesDGV.RowTemplate.Height = 28;
            this.employeesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDGV.ShowCellToolTips = false;
            this.employeesDGV.Size = new System.Drawing.Size(557, 269);
            this.employeesDGV.TabIndex = 7;
            this.employeesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDGV_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(130, 458);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 37);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(968, 458);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 37);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(996, 552);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(121, 37);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(809, 144);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(280, 26);
            this.searchTextbox.TabIndex = 11;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(658, 139);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 37);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            // 
            // adminUsername
            // 
            this.adminUsername.Location = new System.Drawing.Point(339, 60);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(157, 26);
            this.adminUsername.TabIndex = 18;
            this.adminUsername.TextChanged += new System.EventHandler(this.adminUsername_TextChanged);
            // 
            // adminPassword
            // 
            this.adminPassword.Location = new System.Drawing.Point(628, 57);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.Size = new System.Drawing.Size(182, 26);
            this.adminPassword.TabIndex = 19;
            this.adminPassword.TextChanged += new System.EventHandler(this.adminPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Administrator Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Users";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(836, 49);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(121, 37);
            this.logInButton.TabIndex = 23;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(749, 455);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 37);
            this.editButton.TabIndex = 24;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(532, 455);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(121, 37);
            this.newUserButton.TabIndex = 25;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 599);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.adminUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.employeesDGV);
            this.Controls.Add(this.adminRB);
            this.Controls.Add(this.userRB);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.employeeIDTextbox);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeIDTextbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.RadioButton userRB;
        private System.Windows.Forms.RadioButton adminRB;
        private System.Windows.Forms.DataGridView employeesDGV;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminUsername;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newUserButton;
    }
}