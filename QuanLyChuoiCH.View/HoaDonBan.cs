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
    public partial class HoaDonBan : Form
    {
        BUS_CuaHang CH = new BUS_CuaHang();
        BUS_KhachHang KH = new BUS_KhachHang();
        BUS_NhanVien NV = new BUS_NhanVien();
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            cmb_MaCH.DataSource = CH.getdata();
            cmb_MaCH.DisplayMember = "TenCH";
            cmb_MaCH.ValueMember = "MaCH";
            cmb_MaKH.DataSource = KH.GetData();
            cmb_MaKH.DisplayMember = "TenKH";
            cmb_MaKH.ValueMember = "MaKH";
            cmb_MaNV.DataSource = NV.GetData();
            cmb_MaNV.DisplayMember = "TenNV";
            cmb_MaNV.ValueMember = "MaNV";
        }
    }
}
