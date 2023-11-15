namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = txtBox.Text.Trim();
            string gioitinh = cmbBox.SelectedItem.ToString();

            string s = "Họ tên: " + hoten + "\n";
            s += "Giới tính: " + gioitinh + "\n";
            MessageBox.Show(s);
        }
    }
}