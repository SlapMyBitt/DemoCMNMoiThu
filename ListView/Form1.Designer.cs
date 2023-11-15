namespace ListView
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "Job"), new ListViewItem.ListViewSubItem(null, "Sit"), new ListViewItem.ListViewSubItem(null, "Chi", SystemColors.WindowText, Color.Transparent, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem2 = new ListViewItem("Work");
            lvDs = new System.Windows.Forms.ListView();
            C1 = new ColumnHeader();
            C2 = new ColumnHeader();
            C3 = new ColumnHeader();
            SuspendLayout();
            // 
            // lvDs
            // 
            lvDs.Columns.AddRange(new ColumnHeader[] { C1, C2, C3 });
            lvDs.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvDs.Location = new Point(43, -12);
            lvDs.Name = "lvDs";
            lvDs.Size = new Size(713, 426);
            lvDs.TabIndex = 0;
            lvDs.UseCompatibleStateImageBehavior = false;
            lvDs.View = View.Details;
            lvDs.SelectedIndexChanged += lvDs_SelectedIndexChanged;
            // 
            // C1
            // 
            C1.Text = "Gud";
            C1.Width = 120;
            // 
            // C2
            // 
            C2.Text = "More";
            C2.Width = 120;
            // 
            // C3
            // 
            C3.Text = "Ning";
            C3.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvDs);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lvDs;
        private ColumnHeader C1;
        private ColumnHeader C2;
        private ColumnHeader C3;
    }
}