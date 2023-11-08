namespace ShoeStylize
{
    partial class ManageSize
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
            dgvSIze = new DataGridView();
            txtSIze = new TextBox();
            btSizeCreate = new Button();
            btSizeUpdate = new Button();
            btSIzeDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSizeID = new TextBox();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSIze).BeginInit();
            SuspendLayout();
            // 
            // dgvSIze
            // 
            dgvSIze.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSIze.Location = new Point(289, 11);
            dgvSIze.Margin = new Padding(3, 2, 3, 2);
            dgvSIze.Name = "dgvSIze";
            dgvSIze.RowHeadersWidth = 51;
            dgvSIze.RowTemplate.Height = 29;
            dgvSIze.Size = new Size(302, 428);
            dgvSIze.TabIndex = 0;
            dgvSIze.CellDoubleClick += dgvSIze_CellDoubleClick;
            // 
            // txtSIze
            // 
            txtSIze.Location = new Point(87, 162);
            txtSIze.Margin = new Padding(3, 2, 3, 2);
            txtSIze.Name = "txtSIze";
            txtSIze.Size = new Size(164, 23);
            txtSIze.TabIndex = 2;
            // 
            // btSizeCreate
            // 
            btSizeCreate.Location = new Point(169, 225);
            btSizeCreate.Margin = new Padding(3, 2, 3, 2);
            btSizeCreate.Name = "btSizeCreate";
            btSizeCreate.Size = new Size(82, 22);
            btSizeCreate.TabIndex = 3;
            btSizeCreate.Text = "Create";
            btSizeCreate.UseVisualStyleBackColor = true;
            btSizeCreate.Click += btSizeCreate_Click;
            // 
            // btSizeUpdate
            // 
            btSizeUpdate.Enabled = false;
            btSizeUpdate.Location = new Point(81, 225);
            btSizeUpdate.Margin = new Padding(3, 2, 3, 2);
            btSizeUpdate.Name = "btSizeUpdate";
            btSizeUpdate.Size = new Size(82, 22);
            btSizeUpdate.TabIndex = 4;
            btSizeUpdate.Text = "Update";
            btSizeUpdate.UseVisualStyleBackColor = true;
            btSizeUpdate.Click += btSizeUpdate_Click;
            // 
            // btSIzeDelete
            // 
            btSIzeDelete.Enabled = false;
            btSIzeDelete.Location = new Point(81, 269);
            btSIzeDelete.Margin = new Padding(3, 2, 3, 2);
            btSIzeDelete.Name = "btSIzeDelete";
            btSIzeDelete.Size = new Size(82, 22);
            btSIzeDelete.TabIndex = 5;
            btSIzeDelete.Text = "Delete";
            btSIzeDelete.UseVisualStyleBackColor = true;
            btSIzeDelete.Click += btSIzeDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 120);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 6;
            label1.Text = "SIzeID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 165);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 7;
            label2.Text = "Size:";
            // 
            // txtSizeID
            // 
            txtSizeID.Location = new Point(87, 120);
            txtSizeID.Margin = new Padding(3, 2, 3, 2);
            txtSizeID.Name = "txtSizeID";
            txtSizeID.ReadOnly = true;
            txtSizeID.Size = new Size(164, 23);
            txtSizeID.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(169, 269);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ManageSize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(buttonCancel);
            Controls.Add(txtSizeID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btSIzeDelete);
            Controls.Add(btSizeUpdate);
            Controls.Add(btSizeCreate);
            Controls.Add(txtSIze);
            Controls.Add(dgvSIze);
            Name = "ManageSize";
            Text = "Manage Size";
            Load += ManageSize_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSIze).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSIze;
        private TextBox textBox1;
        private TextBox txtSIze;
        private Button btSizeCreate;
        private Button btSizeUpdate;
        private Button btSIzeDelete;
        private Label label1;
        private Label label2;
        private TextBox txtSizeID;
        private Button buttonCancel;
    }
}