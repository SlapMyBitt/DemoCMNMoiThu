using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string item = txtFind.Text;
            lstDs.Items.Add(item);
        }

        //Delete
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string item = txtFind.Text;
            lstDs.Items.Remove(item);
        }

        private void lstDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDs.SelectedItem != null)
            {
                txtFind.Text = lstDs.SelectedItem.ToString();
            }
            else
            {
                txtFind.Clear();
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDs.Items.Count; i++)
            {
                if (Convert.ToInt32(lstDs.Items[i]) % 2 == 0)
                {
                    lstDs.SelectedIndex = i;
                }
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDs.Items.Count; i++)
            {
                if (Convert.ToInt32(lstDs.Items[i]) % 2 != 0)
                {
                    lstDs.SelectedIndex = i;
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {

            var tong = 0;
            foreach (var item in lstDs.Items)
            {
                tong += Convert.ToInt32(item);

            }
            if(lstDs.Items.Count != 0)
            {
                MessageBox.Show("Tong: " + tong);
            }
            else
            {
                MessageBox.Show("Ds trong");
            }
        }

        //End Form
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}