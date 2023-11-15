namespace WApp
{
    partial class Form2
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
            lbA = new Label();
            lbB = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKQ = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new Point(53, 47);
            lbA.Name = "lbA";
            lbA.Size = new Size(40, 20);
            lbA.TabIndex = 0;
            lbA.Text = "Số A";
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new Point(53, 87);
            lbB.Name = "lbB";
            lbB.Size = new Size(39, 20);
            lbB.TabIndex = 1;
            lbB.Text = "Số B";
            // 
            // txtA
            // 
            txtA.Location = new Point(148, 44);
            txtA.Name = "txtA";
            txtA.Size = new Size(225, 27);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(148, 87);
            txtB.Name = "txtB";
            txtB.Size = new Size(225, 27);
            txtB.TabIndex = 3;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(148, 155);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(225, 27);
            txtKQ.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 155);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 5;
            label1.Text = "Kết quả";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtKQ);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lbB);
            Controls.Add(lbA);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbA;
        private Label lbB;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKQ;
        private Label label1;
    }
}