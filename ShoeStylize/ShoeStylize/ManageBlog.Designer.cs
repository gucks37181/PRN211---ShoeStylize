namespace ShoeStylize
{
    partial class ManageBlog
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
            txtUserID = new TextBox();
            txtTitle = new TextBox();
            txtContent = new RichTextBox();
            txtDate = new TextBox();
            dgvBlog = new DataGridView();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            txtPostID = new TextBox();
            label5 = new Label();
            btCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBlog).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 74);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 138);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Content";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 212);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Post Day";
            label4.Click += label4_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(64, 40);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(162, 23);
            txtUserID.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(64, 74);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(838, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(64, 103);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(838, 96);
            txtContent.TabIndex = 7;
            txtContent.Text = "";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(64, 209);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(162, 23);
            txtDate.TabIndex = 8;
            // 
            // dgvBlog
            // 
            dgvBlog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBlog.Location = new Point(14, 267);
            dgvBlog.Name = "dgvBlog";
            dgvBlog.RowTemplate.Height = 25;
            dgvBlog.Size = new Size(888, 302);
            dgvBlog.TabIndex = 9;
            dgvBlog.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(64, 238);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(746, 238);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(827, 238);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // txtPostID
            // 
            txtPostID.Location = new Point(64, 11);
            txtPostID.Name = "txtPostID";
            txtPostID.ReadOnly = true;
            txtPostID.Size = new Size(162, 23);
            txtPostID.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 14);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 13;
            label5.Text = "Post ID";
            // 
            // btCancel
            // 
            btCancel.Enabled = false;
            btCancel.Location = new Point(665, 238);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 15;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // ManageBlog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 581);
            Controls.Add(btCancel);
            Controls.Add(txtPostID);
            Controls.Add(label5);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(dgvBlog);
            Controls.Add(txtDate);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(txtUserID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageBlog";
            Text = "Manage Blog";
            Load += ManageBlog_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBlog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUserID;
        private TextBox txtTitle;
        private RichTextBox txtContent;
        private TextBox txtDate;
        private DataGridView dgvBlog;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox txtPostID;
        private Label label5;
        private Button btCancel;
    }
}