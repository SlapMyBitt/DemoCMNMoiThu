namespace ListBox
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
            lstDanhSach = new System.Windows.Forms.ListBox();
            txtItem = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRemoveAt = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.ItemHeight = 20;
            lstDanhSach.Items.AddRange(new object[] { "Nguyễn CMM", "Nguyễn CMA", "Nguyễn CMB", "Nguyễn CMC", "Nguyễn CMD", "Nguyễn CME" });
            lstDanhSach.Location = new Point(99, 59);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.SelectionMode = SelectionMode.MultiExtended;
            lstDanhSach.Size = new Size(150, 104);
            lstDanhSach.TabIndex = 0;
            lstDanhSach.SelectedIndexChanged += lstDanhSach_SelectedIndexChanged;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(478, 59);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(185, 27);
            txtItem.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(492, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(630, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRemoveAt
            // 
            btnRemoveAt.Location = new Point(355, 215);
            btnRemoveAt.Name = "btnRemoveAt";
            btnRemoveAt.Size = new Size(94, 29);
            btnRemoveAt.TabIndex = 5;
            btnRemoveAt.Text = "RemoveAt";
            btnRemoveAt.UseVisualStyleBackColor = true;
            btnRemoveAt.Click += btnRemoveAt_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(492, 276);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemoveAt);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtItem);
            Controls.Add(lstDanhSach);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhSach;
        private TextBox txtItem;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRemoveAt;
        private Button btnUpdate;
    }
}