namespace GroupBox
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
            grbPC = new System.Windows.Forms.GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cmbBox = new ComboBox();
            txtBox = new TextBox();
            lbGioitinh = new Label();
            lbHoten = new Label();
            tabPage2 = new TabPage();
            btnKQ = new Button();
            tabPage3 = new TabPage();
            grbPC.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // grbPC
            // 
            grbPC.Controls.Add(textBox1);
            grbPC.Location = new Point(65, 60);
            grbPC.Name = "grbPC";
            grbPC.Size = new Size(250, 125);
            grbPC.TabIndex = 0;
            grbPC.TabStop = false;
            grbPC.Text = "PC";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(153, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(384, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(151, 211);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(637, 236);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbBox);
            tabPage1.Controls.Add(txtBox);
            tabPage1.Controls.Add(lbGioitinh);
            tabPage1.Controls.Add(lbHoten);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(629, 203);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbBox
            // 
            cmbBox.FormattingEnabled = true;
            cmbBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbBox.Location = new Point(311, 94);
            cmbBox.Name = "cmbBox";
            cmbBox.Size = new Size(151, 28);
            cmbBox.TabIndex = 3;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(311, 53);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(151, 27);
            txtBox.TabIndex = 2;
            // 
            // lbGioitinh
            // 
            lbGioitinh.AutoSize = true;
            lbGioitinh.Location = new Point(95, 94);
            lbGioitinh.Name = "lbGioitinh";
            lbGioitinh.Size = new Size(65, 20);
            lbGioitinh.TabIndex = 1;
            lbGioitinh.Text = "Giới tính";
            // 
            // lbHoten
            // 
            lbHoten.AutoSize = true;
            lbHoten.Location = new Point(95, 60);
            lbHoten.Name = "lbHoten";
            lbHoten.Size = new Size(54, 20);
            lbHoten.TabIndex = 0;
            lbHoten.Text = "Họ tên";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnKQ);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(629, 203);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kết quả";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKQ
            // 
            btnKQ.Location = new Point(146, 76);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(94, 29);
            btnKQ.TabIndex = 0;
            btnKQ.Text = "Kết quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(629, 203);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(grbPC);
            Name = "Form1";
            Text = "Form1";
            grbPC.ResumeLayout(false);
            grbPC.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grbPC;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cmbBox;
        private TextBox txtBox;
        private Label lbGioitinh;
        private Label lbHoten;
        private Button btnKQ;
    }
}