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
    public partial class Sua_KhachHang : Form
    {
        KhachHang fKH = new KhachHang();
        BUS_KhachHang KH = new BUS_KhachHang();
        public Sua_KhachHang(KhachHang fKH1)
        {
            InitializeComponent();
            fKH = fKH1;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            KH.update(txt_MaKH.Text, txt_TenKH.Text, txt_SDT.Text, txt_SoHD.Text);
            fKH.load();
            this.Close();
        }

        private void Sua_KhachHang_Load(object sender, EventArgs e)
        {
            txt_MaKH.Text = fKH.Lay_MaKH();
            txt_TenKH.Text = fKH.Lay_TenKH();
            txt_SDT.Text = fKH.Lay_SDTKH();
            txt_SoHD.Text = fKH.Lay_SoHDKH();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {

        }
    }
}
