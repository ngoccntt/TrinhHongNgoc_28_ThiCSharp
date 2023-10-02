using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinhHongNgoc_28_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 GPTB2 = new GiaiPhuongTrinhBac2();
            GPTB2.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string HoTenSV = "Trinh Hồng Ngọc";
            string MSSV = "1223360120";
            string Monthi = "Lập Trình Windows 2 C#";

            lblInfor.Text = "Họ và Tên: " + HoTenSV;
            lblInfor.Text += "\nMSSV: " + MSSV;
            lblInfor.Text += "\nTime: " + System.DateTime.Now.ToString();
            lblInfor.Text += "\nMonThi: " + Monthi;
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinhDang DD = new DinhDang();
            DD.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Chương Trình Tiện Ích" , "Thông tin");
        }
    }
}
