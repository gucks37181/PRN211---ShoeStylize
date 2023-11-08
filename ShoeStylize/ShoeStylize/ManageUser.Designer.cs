namespace ShoeStylize
{
    partial class ManageUser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtBirthDate = new TextBox();
            txtRoleID = new TextBox();
            txtGender = new TextBox();
            dgvUser = new DataGridView();
            txtUserID = new TextBox();
            label7 = new Label();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            txtPassword = new TextBox();
            label8 = new Label();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 174);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 232);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Fullname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 262);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 289);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Birthdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 318);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Role ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 347);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            label6.Click += label6_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(75, 229);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(164, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(75, 258);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(75, 286);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(164, 23);
            txtBirthDate.TabIndex = 9;
            txtBirthDate.TextChanged += txtBirthDate_TextChanged;
            // 
            // txtRoleID
            // 
            txtRoleID.Location = new Point(75, 315);
            txtRoleID.Name = "txtRoleID";
            txtRoleID.Size = new Size(164, 23);
            txtRoleID.TabIndex = 10;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(75, 344);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(164, 23);
            txtGender.TabIndex = 11;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(259, 15);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(652, 548);
            dgvUser.TabIndex = 12;
            dgvUser.CellContentClick += dgvUser_CellDoubleClick;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(75, 142);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(164, 23);
            txtUserID.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 145);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 13;
            label7.Text = "User ID";
            label7.Click += label7_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(164, 373);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 15;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(75, 375);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(75, 404);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(75, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 203);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 18;
            label8.Text = "Password";
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(164, 404);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 20;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 575);
            Controls.Add(buttonCancel);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(txtUserID);
            Controls.Add(label7);
            Controls.Add(dgvUser);
            Controls.Add(txtGender);
            Controls.Add(txtRoleID);
            Controls.Add(txtBirthDate);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageUser";
            Text = "Manage User";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtBirthDate;
        private TextBox txtRoleID;
        private TextBox txtGender;
        private DataGridView dgvUser;
        private TextBox txtUserID;
        private Label label7;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox txtPassword;
        private Label label8;
        private Button buttonCancel;
    }
}