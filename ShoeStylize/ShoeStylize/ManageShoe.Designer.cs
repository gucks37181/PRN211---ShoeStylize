namespace ShoeStylize
{
    partial class ManageShoe
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
            dgvShoe = new DataGridView();
            btUpdate = new Button();
            btCreate = new Button();
            btDelete = new Button();
            txtBrandID = new TextBox();
            txtImage = new TextBox();
            txtSize = new TextBox();
            txtShoeName = new TextBox();
            txtShoeID = new TextBox();
            txtPrice = new TextBox();
            txtColor = new TextBox();
            txtSIzeID = new TextBox();
            txtQuanity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            buttonCancel = new Button();
            txtDescrip = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvShoe).BeginInit();
            SuspendLayout();
            // 
            // dgvShoe
            // 
            dgvShoe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoe.Location = new Point(110, 237);
            dgvShoe.Name = "dgvShoe";
            dgvShoe.RowHeadersWidth = 51;
            dgvShoe.RowTemplate.Height = 29;
            dgvShoe.Size = new Size(1131, 500);
            dgvShoe.TabIndex = 0;
            dgvShoe.CellContentClick += dgvshoe_doubleclick;
            // 
            // btUpdate
            // 
            btUpdate.Enabled = false;
            btUpdate.Location = new Point(1, 370);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 1;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(0, 309);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 29);
            btCreate.TabIndex = 2;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btDelete
            // 
            btDelete.Enabled = false;
            btDelete.Location = new Point(0, 422);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 3;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // txtBrandID
            // 
            txtBrandID.Location = new Point(110, 45);
            txtBrandID.Name = "txtBrandID";
            txtBrandID.Size = new Size(207, 27);
            txtBrandID.TabIndex = 4;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(728, 45);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(207, 27);
            txtImage.TabIndex = 6;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(429, 45);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(207, 27);
            txtSize.TabIndex = 7;
            // 
            // txtShoeName
            // 
            txtShoeName.Location = new Point(429, 12);
            txtShoeName.Name = "txtShoeName";
            txtShoeName.Size = new Size(207, 27);
            txtShoeName.TabIndex = 8;
            // 
            // txtShoeID
            // 
            txtShoeID.Location = new Point(110, 11);
            txtShoeID.Name = "txtShoeID";
            txtShoeID.ReadOnly = true;
            txtShoeID.Size = new Size(207, 27);
            txtShoeID.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1034, 45);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(207, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(728, 13);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(207, 27);
            txtColor.TabIndex = 11;
            // 
            // txtSIzeID
            // 
            txtSIzeID.Location = new Point(110, 78);
            txtSIzeID.Name = "txtSIzeID";
            txtSIzeID.Size = new Size(207, 27);
            txtSIzeID.TabIndex = 12;
            // 
            // txtQuanity
            // 
            txtQuanity.Location = new Point(1034, 11);
            txtQuanity.Name = "txtQuanity";
            txtQuanity.Size = new Size(207, 27);
            txtQuanity.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 14;
            label1.Text = "Shoe ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 45);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 15;
            label2.Text = "Brand ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 12);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 16;
            label3.Text = "Shoe name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 129);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 17;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 45);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 18;
            label5.Text = "Size:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(667, 13);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 19;
            label6.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 45);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 20;
            label7.Text = "Image:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(956, 11);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 21;
            label8.Text = "Quanity:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(974, 45);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 22;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 78);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 23;
            label10.Text = "Size ID:";
            label10.Click += label10_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(0, 471);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(95, 31);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // txtDescrip
            // 
            txtDescrip.Location = new Point(110, 111);
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(1131, 120);
            txtDescrip.TabIndex = 25;
            txtDescrip.Text = "";
            // 
            // ManageShoe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 749);
            Controls.Add(txtDescrip);
            Controls.Add(buttonCancel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuanity);
            Controls.Add(txtSIzeID);
            Controls.Add(txtColor);
            Controls.Add(txtPrice);
            Controls.Add(txtShoeID);
            Controls.Add(txtShoeName);
            Controls.Add(txtSize);
            Controls.Add(txtImage);
            Controls.Add(txtBrandID);
            Controls.Add(btDelete);
            Controls.Add(btCreate);
            Controls.Add(btUpdate);
            Controls.Add(dgvShoe);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageShoe";
            Text = "Manage Shoe";
            Load += ManageShoe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShoe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShoe;
        private Button btUpdate;
        private Button btCreate;
        private Button btDelete;
        private TextBox txtBrandID;
        private TextBox txtImage;
        private TextBox txtSize;
        private TextBox txtShoeName;
        private TextBox txtShoeID;
        private TextBox txtPrice;
        private TextBox txtColor;
        private TextBox txtSIzeID;
        private TextBox txtQuanity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button buttonCancel;
        private RichTextBox txtDescrip;
    }
}