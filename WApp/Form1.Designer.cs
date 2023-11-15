namespace WApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            errorProvider1 = new ErrorProvider(components);
            lbSNA = new Label();
            Cong = new Button();
            Tru = new Button();
            Chia = new Button();
            Nhan = new Button();
            lbSNB = new Label();
            txtKQ = new TextBox();
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbSNA
            // 
            lbSNA.AutoSize = true;
            lbSNA.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSNA.Location = new Point(126, 90);
            lbSNA.Name = "lbSNA";
            lbSNA.Size = new Size(83, 17);
            lbSNA.TabIndex = 0;
            lbSNA.Text = "Số nguyên A";
            // 
            // Cong
            // 
            Cong.Location = new Point(206, 251);
            Cong.Name = "Cong";
            Cong.Size = new Size(94, 29);
            Cong.TabIndex = 2;
            Cong.Text = "Cộng\r\n\r\n";
            Cong.UseVisualStyleBackColor = true;
            Cong.Click += Cong_Click;
            // 
            // Tru
            // 
            Tru.Location = new Point(415, 251);
            Tru.Name = "Tru";
            Tru.Size = new Size(94, 29);
            Tru.TabIndex = 3;
            Tru.Text = "Trừ";
            Tru.UseVisualStyleBackColor = true;
            Tru.Click += Tru_Click;
            // 
            // Chia
            // 
            Chia.Location = new Point(826, 251);
            Chia.Name = "Chia";
            Chia.Size = new Size(94, 29);
            Chia.TabIndex = 5;
            Chia.Text = "Chia";
            Chia.UseVisualStyleBackColor = true;
            Chia.Click += Chia_Click;
            // 
            // Nhan
            // 
            Nhan.Location = new Point(622, 251);
            Nhan.Name = "Nhan";
            Nhan.Size = new Size(94, 29);
            Nhan.TabIndex = 6;
            Nhan.Text = "Nhân";
            Nhan.UseVisualStyleBackColor = true;
            Nhan.Click += Nhan_Click;
            // 
            // lbSNB
            // 
            lbSNB.AutoSize = true;
            lbSNB.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSNB.Location = new Point(126, 156);
            lbSNB.Name = "lbSNB";
            lbSNB.Size = new Size(83, 17);
            lbSNB.TabIndex = 7;
            lbSNB.Text = "Số nguyên B";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(1067, 79);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(125, 27);
            txtKQ.TabIndex = 9;
            // 
            // txtSoA
            // 
            txtSoA.Location = new Point(331, 84);
            txtSoA.Name = "txtSoA";
            txtSoA.Size = new Size(589, 27);
            txtSoA.TabIndex = 10;
            // 
            // txtSoB
            // 
            txtSoB.Location = new Point(331, 156);
            txtSoB.Name = "txtSoB";
            txtSoB.Size = new Size(589, 27);
            txtSoB.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1279, 650);
            Controls.Add(txtSoB);
            Controls.Add(txtSoA);
            Controls.Add(txtKQ);
            Controls.Add(lbSNB);
            Controls.Add(Nhan);
            Controls.Add(Chia);
            Controls.Add(Tru);
            Controls.Add(Cong);
            Controls.Add(lbSNA);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button Nhan;
        private Button Chia;
        private Button Tru;
        private Button Cong;
        private Label lbSNA;
        private Label lbSNB;
        private TextBox txtKQ;
        private TextBox txtSoB;
        private TextBox txtSoA;
    }
}