namespace ShoeStylize
{
    partial class ManageBrand
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
            dgvBrand = new DataGridView();
            txtBrandName = new TextBox();
            txtBrandId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btBrUpdate = new Button();
            btBrCreate = new Button();
            btBrDelete = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBrand).BeginInit();
            SuspendLayout();
            // 
            // dgvBrand
            // 
            dgvBrand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrand.Location = new Point(318, 9);
            dgvBrand.Margin = new Padding(3, 2, 3, 2);
            dgvBrand.Name = "dgvBrand";
            dgvBrand.RowHeadersWidth = 51;
            dgvBrand.RowTemplate.Height = 29;
            dgvBrand.Size = new Size(471, 432);
            dgvBrand.TabIndex = 0;
            dgvBrand.CellContentClick += dgvBrand_CellDoubleClick;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(123, 168);
            txtBrandName.Margin = new Padding(3, 2, 3, 2);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(164, 23);
            txtBrandName.TabIndex = 1;
            // 
            // txtBrandId
            // 
            txtBrandId.Location = new Point(123, 134);
            txtBrandId.Margin = new Padding(3, 2, 3, 2);
            txtBrandId.Multiline = true;
            txtBrandId.Name = "txtBrandId";
            txtBrandId.ReadOnly = true;
            txtBrandId.Size = new Size(164, 21);
            txtBrandId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 140);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Brand ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 176);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Brand name:";
            // 
            // btBrUpdate
            // 
            btBrUpdate.Enabled = false;
            btBrUpdate.Location = new Point(123, 242);
            btBrUpdate.Margin = new Padding(3, 2, 3, 2);
            btBrUpdate.Name = "btBrUpdate";
            btBrUpdate.Size = new Size(82, 22);
            btBrUpdate.TabIndex = 5;
            btBrUpdate.Text = "Update";
            btBrUpdate.UseVisualStyleBackColor = true;
            btBrUpdate.Click += btBrUpdate_Click;
            // 
            // btBrCreate
            // 
            btBrCreate.Location = new Point(205, 242);
            btBrCreate.Margin = new Padding(3, 2, 3, 2);
            btBrCreate.Name = "btBrCreate";
            btBrCreate.Size = new Size(82, 22);
            btBrCreate.TabIndex = 6;
            btBrCreate.Text = "Create";
            btBrCreate.UseVisualStyleBackColor = true;
            btBrCreate.Click += btBrCreate_Click;
            // 
            // btBrDelete
            // 
            btBrDelete.Enabled = false;
            btBrDelete.Location = new Point(123, 268);
            btBrDelete.Margin = new Padding(3, 2, 3, 2);
            btBrDelete.Name = "btBrDelete";
            btBrDelete.Size = new Size(82, 22);
            btBrDelete.TabIndex = 7;
            btBrDelete.Text = "Delete";
            btBrDelete.UseVisualStyleBackColor = true;
            btBrDelete.Click += btBrDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(205, 267);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(81, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ManageBrand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(btBrDelete);
            Controls.Add(btBrCreate);
            Controls.Add(btBrUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBrandId);
            Controls.Add(txtBrandName);
            Controls.Add(dgvBrand);
            Name = "ManageBrand";
            Text = "Manage Brand";
            ((System.ComponentModel.ISupportInitialize)dgvBrand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBrand;
        private TextBox txtBrandName;
        private TextBox txtBrandId;
        private Label label1;
        private Label label2;
        private Button btBrUpdate;
        private Button btBrCreate;
        private Button btBrDelete;
        private Button buttonCancel;
    }
}