using QuanLyChuoiCH.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiCH.View
{
    public partial class Them_KhachHang : Form
    {
        BUS_KhachHang KH = new BUS_KhachHang();
        KhachHang fKH = new KhachHang();
        public Them_KhachHang(KhachHang fKH1)
        {
            InitializeComponent();
            fKH = fKH1;
        }

        private void Them_KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            KH.insertData(txt_MaSP.Text, txt_TenSP.Text, txt_GiaBan.Text, textBox1.Text);
            
            fKH.load();
            this.Close();
        }
    }
}
