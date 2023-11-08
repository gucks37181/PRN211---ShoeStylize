namespace ShoeStylize
{
    partial class ProviderManage
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
            label2 = new Label();
            button3 = new Button();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 16);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 10;
            label2.Text = "Welcone, Provider";
            // 
            // button3
            // 
            button3.Location = new Point(365, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 59);
            label1.Name = "label1";
            label1.Size = new Size(339, 38);
            label1.TabIndex = 8;
            label1.Text = "Provider Management";
            // 
            // button2
            // 
            button2.Location = new Point(167, 157);
            button2.Name = "button2";
            button2.Size = new Size(126, 111);
            button2.TabIndex = 7;
            button2.Text = "Manage Shoes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 157);
            button1.Name = "button1";
            button1.Size = new Size(122, 111);
            button1.TabIndex = 6;
            button1.Text = "Manage Brands";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(299, 157);
            button4.Name = "button4";
            button4.Size = new Size(119, 111);
            button4.TabIndex = 11;
            button4.Text = "Manage Size";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ProviderManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 309);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ProviderManage";
            Text = "Provider Manage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button3;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}