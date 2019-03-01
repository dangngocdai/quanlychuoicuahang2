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
        CuaHang fCH = new CuaHang();
        BUS_CuaHang CH = new BUS_CuaHang();
        BUS_KhachHang KH = new BUS_KhachHang();
        BUS_NhanVien NV = new BUS_NhanVien();
        KhachHang fKH = new KhachHang();
        public HoaDonBan(CuaHang fCH1)
        {
            InitializeComponent();
            fCH = fCH1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            /*cmb_MaCH.DataSource = CH.getdata();
            cmb_MaCH.DisplayMember = "TenCH";
            cmb_MaCH.ValueMember = "MaCH";*/
            txt_CH.Text = fCH.layTenCH();
            cmb_MaKH.DataSource = KH.GetData();
            cmb_MaKH.DisplayMember = "TenKH";
            cmb_MaKH.ValueMember = "MaKH";
            cmb_MaNV.DataSource = NV.GetData();
            cmb_MaNV.DisplayMember = "TenNV";
            cmb_MaNV.ValueMember = "MaNV";
            load();
        }
        public void load()
        {
            
            cmb_MaKH.DataSource = KH.GetData();
            cmb_MaKH.DisplayMember = "TenKH";
            cmb_MaKH.ValueMember = "MaKH";
            cmb_MaNV.DataSource = NV.GetData();
            cmb_MaNV.DisplayMember = "TenNV";
            cmb_MaNV.ValueMember = "MaNV";
        }
        public string LayMaCH()
        {
            return txt_CH.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< dataGridView1.ColumnCount; i++)
            {
                //MessageBox.Show(" " + dataGridView1.Rows[i].Cells[0]);
                // insert 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SPTonCH f = new SPTonCH(fCH);
            f.Show();
        }

        private void bt_ThemKH_Click(object sender, EventArgs e)
        {
            Them_KhachHang f = new Them_KhachHang(fKH);
            f.Show();
        }
    }
}
