using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuoiCH.BUS;

namespace QuanLyChuoiCH.View
{
    public partial class FormDangNhap : Form
    {
        BUS_Uses us = new BUS_Uses();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = us.checkDangNhap(txt_TK.Text, txt_MK.Text);
            if (kq == 0)
                MessageBox.Show("DangNhapThatBai");
            else
            {
                //MessageBox.Show("DangNhapThanhCong");
                CuaHang f = new CuaHang();
                f.Show();
               
            }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txt_TK.Text == "Tên đăng nhập")
                txt_TK.Text = "";
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txt_TK.Text == "")
                txt_TK.Text = "Tên đăng nhập";
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txt_MK.Text == "Mật khẩu")
            {
                txt_MK.Text = "";
                txt_MK.UseSystemPasswordChar = false;
            }

        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txt_MK.Text == "")
            {
                txt_MK.Text = "Mật khẩu";
                txt_MK.UseSystemPasswordChar = true;
            }

        }
        private void Dai(object sender, EventArgs e)
        {

        }
    }
}
