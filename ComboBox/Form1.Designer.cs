namespace ComboBox
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
            cboDanhSach = new System.Windows.Forms.ComboBox();
            btnAdd = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // cboDanhSach
            // 
            cboDanhSach.FormattingEnabled = true;
            cboDanhSach.Items.AddRange(new object[] { "Nguyễn ĐMCĐ", "Thị Tám", "Bà 4", "Chú 7" });
            cboDanhSach.Location = new Point(129, 94);
            cboDanhSach.Name = "cboDanhSach";
            cboDanhSach.Size = new Size(151, 28);
            cboDanhSach.TabIndex = 0;
            cboDanhSach.Text = "Look at me!";
            cboDanhSach.SelectedIndexChanged += cboDanhSach_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(274, 220);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(cboDanhSach);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cboDanhSach;
        private Button btnAdd;
        private Button btnRemove;
    }
}