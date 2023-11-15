namespace Test1
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
            lbNhapso = new Label();
            txtFind = new TextBox();
            btnUpdate = new Button();
            btnTong = new Button();
            grbDanhsach = new GroupBox();
            lstDs = new ListBox();
            grbChucnang = new GroupBox();
            btnLe = new Button();
            btnXoa = new Button();
            btnChan = new Button();
            btnEnd = new Button();
            grbDanhsach.SuspendLayout();
            grbChucnang.SuspendLayout();
            SuspendLayout();
            // 
            // lbNhapso
            // 
            lbNhapso.AutoSize = true;
            lbNhapso.Location = new Point(48, 39);
            lbNhapso.Name = "lbNhapso";
            lbNhapso.Size = new Size(67, 20);
            lbNhapso.TabIndex = 0;
            lbNhapso.Text = "Nhập số:";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(180, 39);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(728, 27);
            txtFind.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(967, 39);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(35, 42);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(342, 45);
            btnTong.TabIndex = 6;
            btnTong.Text = "Tổng của danh sách";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // grbDanhsach
            // 
            grbDanhsach.Controls.Add(lstDs);
            grbDanhsach.Location = new Point(48, 86);
            grbDanhsach.Name = "grbDanhsach";
            grbDanhsach.Size = new Size(419, 356);
            grbDanhsach.TabIndex = 7;
            grbDanhsach.TabStop = false;
            grbDanhsach.Text = "Danh sách";
            // 
            // lstDs
            // 
            lstDs.FormattingEnabled = true;
            lstDs.ItemHeight = 20;
            lstDs.Items.AddRange(new object[] { "100", "99", "90", "00" });
            lstDs.Location = new Point(6, 26);
            lstDs.Name = "lstDs";
            lstDs.SelectionMode = SelectionMode.MultiExtended;
            lstDs.Size = new Size(407, 324);
            lstDs.TabIndex = 0;
            lstDs.SelectedIndexChanged += lstDs_SelectedIndexChanged;
            // 
            // grbChucnang
            // 
            grbChucnang.Controls.Add(btnLe);
            grbChucnang.Controls.Add(btnXoa);
            grbChucnang.Controls.Add(btnChan);
            grbChucnang.Controls.Add(btnTong);
            grbChucnang.Location = new Point(508, 86);
            grbChucnang.Name = "grbChucnang";
            grbChucnang.Size = new Size(419, 356);
            grbChucnang.TabIndex = 8;
            grbChucnang.TabStop = false;
            grbChucnang.Text = "Chức năng";
            // 
            // btnLe
            // 
            btnLe.Location = new Point(35, 268);
            btnLe.Name = "btnLe";
            btnLe.Size = new Size(342, 45);
            btnLe.TabIndex = 9;
            btnLe.Text = "Chọn số lẻ";
            btnLe.UseVisualStyleBackColor = true;
            btnLe.Click += btnLe_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(35, 118);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(342, 45);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa phần tử đang chọn";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnChan
            // 
            btnChan.Location = new Point(35, 194);
            btnChan.Name = "btnChan";
            btnChan.Size = new Size(342, 45);
            btnChan.TabIndex = 7;
            btnChan.Text = "Chọn số chẵn";
            btnChan.UseVisualStyleBackColor = true;
            btnChan.Click += btnChan_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(48, 462);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(879, 45);
            btnEnd.TabIndex = 10;
            btnEnd.Text = "Kết thúc";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 519);
            Controls.Add(btnEnd);
            Controls.Add(grbChucnang);
            Controls.Add(grbDanhsach);
            Controls.Add(btnUpdate);
            Controls.Add(txtFind);
            Controls.Add(lbNhapso);
            Name = "Form1";
            Text = "Form1";
            grbDanhsach.ResumeLayout(false);
            grbChucnang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNhapso;
        private TextBox txtFind;
        private Button btnUpdate;
        private Button button3;
        private Button btnTong;
        private GroupBox grbDanhsach;
        private GroupBox grbChucnang;
        private Button btnXoa;
        private Button btnChan;
        private Button btnLe;
        private Button btnEnd;
        private ListBox lstDs;
    }
}