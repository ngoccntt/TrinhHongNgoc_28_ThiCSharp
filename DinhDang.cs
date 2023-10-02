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
    public partial class DinhDang : Form
    {
        public DinhDang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtlt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnhap_TextChanged(object sender, EventArgs e)
        {
            txtlt.Text = txtnhap.Text;
            lbllt.Text = txtnhap.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            txtnhap.ForeColor = Color.Red;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            txtnhap.ForeColor = Color.Green;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            txtnhap.ForeColor = Color.Blue;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            txtnhap.ForeColor = Color.Black;
        }

        private void DinhDang_Load(object sender, EventArgs e)
        {
            radred.Checked = true;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lbllt.Font = new Font(lbllt.Font.Name, lbllt.Font.Size,
            lbllt.Font.Style ^ FontStyle.Bold);
            txtlt.Font = new Font(txtlt.Font.Name, txtlt.Font.Size,
            txtlt.Font.Style ^ FontStyle.Bold);
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            lbllt.Font = new Font(lbllt.Font.Name, lbllt.Font.Size,
            lbllt.Font.Style ^ FontStyle.Underline);
            txtlt.Font = new Font(txtlt.Font.Name, txtlt.Font.Size,
            txtlt.Font.Style ^ FontStyle.Underline);
        }

        private void chkunder_CheckedChanged(object sender, EventArgs e)
        {
            lbllt.Font = new Font(lbllt.Font.Name, lbllt.Font.Size,
            lbllt.Font.Style ^ FontStyle.Italic);
            txtlt.Font = new Font(txtlt.Font.Name, txtlt.Font.Size,
            txtlt.Font.Style ^ FontStyle.Italic);

        }
    }
}





