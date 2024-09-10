using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát",
                "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(CheckDangNhap())
            {
                SanPham f = new SanPham();
                f.Show();
                this.Hide();
            }    
        }
        private bool CheckDangNhap()
        {
            if (txbTenDangNhap.Text == "")
            {
                errorProvider1.SetError(txbTenDangNhap, "Bạn chưa nhập tên đăng nhập");
                return false;
            }
            else if (txbPassword.Text == "")  
            {
                errorProvider1.SetError(txbPassword, "Bạn chưa nhập mật khẩu");
                return false;
            }
            return true;
        }

    }
}
