namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = cmsColor.SourceControl as Button; // btn là đối tượng chung cho tất cả các Button
            btnColor.BackColor = Color.Red;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn1 = cmsColor.SourceControl as Button;
            btnColor1.BackColor = Color.Aqua;
        }
    }
}