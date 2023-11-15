namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Trả về giá trị được lựa chọn
        private void cboDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Gia tri duoc lua chon la:" + cboDanhSach.SelectedItem);
        }

        //Thêm nhiều phần tử cùng lúc
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //cboDanhSach.Items.AddRange(new string[] { "A", "B", "C" }); //thêm nhiều
            string[] data = { "D", "E", "F" }; //ghi đè lên dữ liệu cũ
            cboDanhSach.DataSource = data;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cboDanhSach.Items.Remove(1);
        }
    }
}