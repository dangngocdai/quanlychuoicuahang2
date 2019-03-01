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
    public partial class Them_SanPham : Form
    {
        private BUS_LoaiSP LSP = new BUS_LoaiSP();
        private BUS_NhomSP NSP = new BUS_NhomSP();
        private BUS_NhaCC NCC = new BUS_NhaCC();
        private BUS_SP SP = new BUS_SP();
        private SanPham FSP = new SanPham();
        public Them_SanPham(SanPham SP)
        {
            InitializeComponent();
            FSP = SP;
        }

        private void Them_SanPham_Load(object sender, EventArgs e)
        {
            cmb_LoaiSP.DataSource = LSP.GetData();
            cmb_LoaiSP.DisplayMember = "TenLoaiSP";
            cmb_LoaiSP.ValueMember = "MaLoaiSP";
            cmb_NhomSP.DataSource = NSP.GetData();
            cmb_NhomSP.DisplayMember = "TenNhomSP";
            cmb_NhomSP.ValueMember = "MaNhomSP";
            cmb_MaNCC.DataSource = NCC.GetData();
            cmb_MaNCC.DisplayMember = "TenNCC";
            cmb_MaNCC.ValueMember = "MaNCC";
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            SP.insertData(txt_MaSP.Text, txt_TenSP.Text, cmb_LoaiSP.SelectedValue.ToString(), cmb_MaNCC.SelectedValue.ToString(), Rtxt_ThongTin.Text, txt_GiaBan.Text, txt_BaoHanh.Text);
            FSP.load();
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
