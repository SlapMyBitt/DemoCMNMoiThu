namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            lstDanhSach.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            lstDanhSach.Items.Remove(item);
        }


        //Xóa ở Index thứ 
        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            lstDanhSach.Items.RemoveAt(2);
        }

        //Sửa
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items[0] = txtItem.Text;
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem != null)
            {
                txtItem.Text = lstDanhSach.SelectedItem.ToString();
            }
            else
            {
                txtItem.Clear();
            }
        }
    }
}