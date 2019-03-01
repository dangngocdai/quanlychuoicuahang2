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
    public partial class Sua_SanPham : Form
    {
        private BUS_SP SP = new BUS_SP();
        private BUS_LoaiSP LSP = new BUS_LoaiSP();
        private BUS_NhomSP NSP = new BUS_NhomSP();
        private BUS_NhaCC NCC = new BUS_NhaCC();
        private SanPham FSP = new SanPham();

        public Sua_SanPham(SanPham FSP1)
        {
            InitializeComponent();
            FSP = FSP1;
        }

        private void Sua_SanPham_Load(object sender, EventArgs e)
        {
            cmb_LoaiSP.DataSource = LSP.GetData();
            //cmb_NhomSP.DataSource = NSP.GetData();
            cmb_MaNCC.DataSource = NCC.GetData();
            cmb_LoaiSP.DisplayMember = "TenLoaiSP";
            cmb_LoaiSP.ValueMember = "MaLoaiSP";
            //cmb_NhomSP.DisplayMember = "TenNhomSP";
            //cmb_NhomSP.ValueMember = "MaNhomSP";
            cmb_MaNCC.DisplayMember = "TenNCC";
            cmb_MaNCC.ValueMember = "MaNCC";
            //cmb_LoaiSP.Text = FSP.layLoaiSanPham();
            //cmb_NhomSP.Text = FSP.layNhomSanPham();
            //cmb_MaNCC.Text = FSP.layNhaCC();
            txt_MaSP.Text = FSP.layMaSanPham();
            txt_TenSP.Text = FSP.layTenSanPham();
            Rtxt_ThongTin.Text = FSP.layThongTin();
            txt_GiaBan.Text = FSP.layGiaBan();
            txt_BaoHanh.Text = FSP.layBaoHanh();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            SP.update(txt_MaSP.Text, txt_TenSP.Text, cmb_LoaiSP.SelectedValue.ToString(), cmb_MaNCC.SelectedValue.ToString(), Rtxt_ThongTin.Text, txt_GiaBan.Text, txt_BaoHanh.Text);
            FSP.load();
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
