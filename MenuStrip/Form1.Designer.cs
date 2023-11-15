namespace MenuStrip
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            msClose = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            btnColor = new Button();
            cmsColor = new ContextMenuStrip(components);
            redToolStripMenuItem = new ToolStripMenuItem();
            limeToolStripMenuItem = new ToolStripMenuItem();
            grayToolStripMenuItem = new ToolStripMenuItem();
            aquaToolStripMenuItem = new ToolStripMenuItem();
            btnColor1 = new Button();
            menuStrip1.SuspendLayout();
            cmsColor.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, msClose });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(181, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // msClose
            // 
            msClose.Name = "msClose";
            msClose.Size = new Size(181, 26);
            msClose.Text = "Close";
            msClose.Click += msClose_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // btnColor
            // 
            btnColor.ContextMenuStrip = cmsColor;
            btnColor.Location = new Point(440, 181);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(94, 29);
            btnColor.TabIndex = 1;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // cmsColor
            // 
            cmsColor.BackColor = SystemColors.ActiveBorder;
            cmsColor.ImageScalingSize = new Size(20, 20);
            cmsColor.Items.AddRange(new ToolStripItem[] { redToolStripMenuItem, limeToolStripMenuItem, grayToolStripMenuItem, aquaToolStripMenuItem });
            cmsColor.Name = "cmsColor";
            cmsColor.Size = new Size(211, 128);
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(210, 24);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // limeToolStripMenuItem
            // 
            limeToolStripMenuItem.Name = "limeToolStripMenuItem";
            limeToolStripMenuItem.Size = new Size(210, 24);
            limeToolStripMenuItem.Text = "Lime";
            // 
            // grayToolStripMenuItem
            // 
            grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            grayToolStripMenuItem.Size = new Size(210, 24);
            grayToolStripMenuItem.Text = "Gray";
            // 
            // aquaToolStripMenuItem
            // 
            aquaToolStripMenuItem.Name = "aquaToolStripMenuItem";
            aquaToolStripMenuItem.Size = new Size(210, 24);
            aquaToolStripMenuItem.Text = "Aqua";
            aquaToolStripMenuItem.Click += aquaToolStripMenuItem_Click;
            // 
            // btnColor1
            // 
            btnColor1.ContextMenuStrip = cmsColor;
            btnColor1.Location = new Point(440, 248);
            btnColor1.Name = "btnColor1";
            btnColor1.Size = new Size(94, 29);
            btnColor1.TabIndex = 2;
            btnColor1.Text = "Color1";
            btnColor1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnColor1);
            Controls.Add(btnColor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            cmsColor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem msClose;
        private ToolStripMenuItem editToolStripMenuItem;
        private Button btnColor;
        private ContextMenuStrip cmsColor;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem limeToolStripMenuItem;
        private ToolStripMenuItem grayToolStripMenuItem;
        private Button btnColor1;
        private ToolStripMenuItem aquaToolStripMenuItem;
    }
}