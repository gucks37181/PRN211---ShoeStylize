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
            txtDescrip = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvShoe).BeginInit();
            SuspendLayout();
            // 
            // dgvShoe
            // 
            dgvShoe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoe.Location = new Point(301, 11);
            dgvShoe.Margin = new Padding(3, 2, 3, 2);
            dgvShoe.Name = "dgvShoe";
            dgvShoe.RowHeadersWidth = 51;
            dgvShoe.RowTemplate.Height = 29;
            dgvShoe.Size = new Size(608, 540);
            dgvShoe.TabIndex = 0;
            dgvShoe.CellContentClick += dgvshoe_doubleclick;
            // 
            // btUpdate
            // 
            btUpdate.Enabled = false;
            btUpdate.Location = new Point(96, 375);
            btUpdate.Margin = new Padding(3, 2, 3, 2);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(82, 22);
            btUpdate.TabIndex = 1;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(195, 375);
            btCreate.Margin = new Padding(3, 2, 3, 2);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(82, 22);
            btCreate.TabIndex = 2;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btDelete
            // 
            btDelete.Enabled = false;
            btDelete.Location = new Point(96, 412);
            btDelete.Margin = new Padding(3, 2, 3, 2);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(82, 22);
            btDelete.TabIndex = 3;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // txtBrandID
            // 
            txtBrandID.Location = new Point(96, 140);
            txtBrandID.Margin = new Padding(3, 2, 3, 2);
            txtBrandID.Name = "txtBrandID";
            txtBrandID.Size = new Size(182, 23);
            txtBrandID.TabIndex = 4;
            // 
            // txtDescrip
            // 
            txtDescrip.Location = new Point(96, 189);
            txtDescrip.Margin = new Padding(3, 2, 3, 2);
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(182, 23);
            txtDescrip.TabIndex = 5;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(96, 267);
            txtImage.Margin = new Padding(3, 2, 3, 2);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(182, 23);
            txtImage.TabIndex = 6;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(96, 216);
            txtSize.Margin = new Padding(3, 2, 3, 2);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(182, 23);
            txtSize.TabIndex = 7;
            // 
            // txtShoeName
            // 
            txtShoeName.Location = new Point(96, 165);
            txtShoeName.Margin = new Padding(3, 2, 3, 2);
            txtShoeName.Name = "txtShoeName";
            txtShoeName.Size = new Size(182, 23);
            txtShoeName.TabIndex = 8;
            // 
            // txtShoeID
            // 
            txtShoeID.Location = new Point(96, 115);
            txtShoeID.Margin = new Padding(3, 2, 3, 2);
            txtShoeID.Name = "txtShoeID";
            txtShoeID.ReadOnly = true;
            txtShoeID.Size = new Size(182, 23);
            txtShoeID.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(96, 317);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(96, 243);
            txtColor.Margin = new Padding(3, 2, 3, 2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(182, 23);
            txtColor.TabIndex = 11;
            // 
            // txtSIzeID
            // 
            txtSIzeID.Location = new Point(96, 341);
            txtSIzeID.Margin = new Padding(3, 2, 3, 2);
            txtSIzeID.Name = "txtSIzeID";
            txtSIzeID.Size = new Size(182, 23);
            txtSIzeID.TabIndex = 12;
            // 
            // txtQuanity
            // 
            txtQuanity.Location = new Point(96, 292);
            txtQuanity.Margin = new Padding(3, 2, 3, 2);
            txtQuanity.Name = "txtQuanity";
            txtQuanity.Size = new Size(182, 23);
            txtQuanity.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 115);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 14;
            label1.Text = "Shoe ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 140);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 15;
            label2.Text = "Brand ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 165);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 16;
            label3.Text = "Shoe name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 189);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 17;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 216);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 18;
            label5.Text = "Size:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 243);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 19;
            label6.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 267);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 20;
            label7.Text = "Image:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 292);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 21;
            label8.Text = "Quanity:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 317);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 22;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 341);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 23;
            label10.Text = "Size ID:";
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(195, 411);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(83, 23);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ManageShoe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 562);
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
            Controls.Add(txtDescrip);
            Controls.Add(txtBrandID);
            Controls.Add(btDelete);
            Controls.Add(btCreate);
            Controls.Add(btUpdate);
            Controls.Add(dgvShoe);
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
        private TextBox txtDescrip;
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
    }
}