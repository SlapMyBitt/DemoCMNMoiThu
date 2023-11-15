using Microsoft.VisualBasic;

namespace WApp
{
    public partial class Form1 : Form
    {
        int soA;
        int soB;
        public void Nhap()
        {
            string soA = txtSoA.Text;
            string soB = txtSoB.Text;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Hàm check
        //Nhập liệu textbox, check kiểu dữ liệu
        public bool KiemTraNhapLieu()
        {
            bool check = true;
            //Nhập textbox
            string dataA = txtSoA.Text;
            string dataB = txtSoB.Text;
            //Kiểm tra
            if(string.IsNullOrEmpty(dataA) || string.IsNullOrEmpty(dataB))
            {
                check = false;
                MessageBox.Show("Chua nhap du lieu!", "Thong bao!");
            }
            else if(!int.TryParse(dataA,out soA) || !int.TryParse(dataB,out soB))
            {
                check = false;
                MessageBox.Show("Nhap sai kieu ki tu!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                check = true;
                soA = Int32.Parse(dataA);
                soB = Int32.Parse(dataB);
            }
            return check;
        }

        private void Cong_Click(object sender, EventArgs e)
        {
            if(KiemTraNhapLieu())
            {
                int tong = soA + soB;
                txtKQ.Text = tong.ToString();
            }
            //string soA = txtSoA.Text; //Số a,b có kiểu dữ liệu string
            //string soB = txtSoB.Text;
            //int Tong = int.Parse(soA) + int.Parse(soB);
            //txtKQ.Text = Tong.ToString();
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                int Hieu = soA - soB;
                txtKQ.Text = Hieu.ToString();
            }
            //string soA = txtSoA.Text; //Số a,b có kiểu dữ liệu string
            //string soB = txtSoB.Text;
            //int Hieu = int.Parse(soA) - int.Parse(soB);
            //txtKQ.Text = Hieu.ToString();
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                int Tich = soA * soB;
                txtKQ.Text = Tich.ToString();
            }
            //string soA = txtSoA.Text; //Số a,b có kiểu dữ liệu string
            //string soB = txtSoB.Text;
            //int Tich = int.Parse(soA) * int.Parse(soB);
            //txtKQ.Text = Tich.ToString();
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                if(soB == 0)
                {
                    MessageBox.Show("Mau so phai khac 0", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Thuong = soA / soB;
                    txtKQ.Text = Thuong.ToString();
                }
            }
            //string soA = txtSoA.Text; //Số a,b có kiểu dữ liệu string
            //string soB = txtSoB.Text;
            //int Thuong = int.Parse(soA) / int.Parse(soB);
            //txtKQ.Text = Thuong.ToString();
        }
    }
}