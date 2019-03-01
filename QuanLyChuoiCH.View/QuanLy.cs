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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void bt_CH_Click(object sender, EventArgs e)
        {
            CuaHang f = new CuaHang();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kho f = new Kho();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SanPham f = new SanPham();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NgQuanLy f = new NgQuanLy();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhaCC f = new NhaCC();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            f.Show();
        }
    }
}
