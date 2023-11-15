namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check xem có dòng nào được chọn hay không
            if(lvDs.SelectedItems.Count > 0)
            {
                // Click vào Columm đầu tiên để hiện thông báo
                ListViewItem item = lvDs.SelectedItems[0];
                string gud = item.SubItems[0].Text;
                string more = item.SubItems[1].Text;
                string ning = item.SubItems[2].Text;
                MessageBox.Show(gud + "/" + more + "/" + ning , "Thông báo!");
            }
        }
    }
}