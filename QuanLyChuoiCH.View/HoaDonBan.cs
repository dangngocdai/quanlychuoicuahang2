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
        BUS_CTHDBan CTHDBan = new BUS_CTHDBan();
        BUS_HDBan HDBan = new BUS_HDBan();
        public string macuahang = "";
        
        public HoaDonBan(CuaHang fCH1)
        {
            InitializeComponent();
            fCH = fCH1;
            macuahang = fCH1.layMaCH();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString() + dataGridView1.RowCount);
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
        public string date()
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            return month + "/" + day + "/" + year;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String MaCH = fCH.layMaCH();
            HDBan.insertData(txt_MaHD.Text,MaCH, cmb_MaKH.SelectedValue.ToString(), date(), txt_ThongTin.Text, cmb_MaNV.SelectedValue.ToString());
            for(int i = 0; i< dataGridView1.RowCount - 1; i++)
            {
                //MessageBox.Show(" " + dataGridView1.Rows[i].Cells[0]);
                string MaHDBan = txt_MaHD.Text;
                string cotMaSP = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string cotSoLuong = dataGridView1.Rows[i].Cells[3].Value.ToString();
                CTHDBan.insertData(MaHDBan, cotMaSP, cotSoLuong);
            }

            fCH.load();
            this.Close();
            
            //CTHDBan.insertData()

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SPTonCH f = new SPTonCH(this);
            
            f.Show();
        }
        public void add(string MaSP,string TenSP, string LoaiSP, string NCC, string ThongTin, string GiaBan, string BaoHanh )
        {

            txt_MaSP.Text = MaSP;
            txt_TenSP.Text = TenSP;
            txt_LoaiSP.Text = LoaiSP;
            txt_NCC.Text = NCC;
            txt_ThongTinSP.Text = ThongTin;
            txt_GiaBan.Text = GiaBan;
            txt_BaoHanh.Text = BaoHanh;
        }
        private void bt_ThemKH_Click(object sender, EventArgs e)
        {
            Them_KhachHang f = new Them_KhachHang(this);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int giaban = (int) num_SoSP.Value * Int32.Parse(txt_GiaBan.Text) ;
            dataGridView1.Rows.Add(txt_MaSP.Text, txt_TenSP.Text, txt_LoaiSP.Text, num_SoSP.Value,giaban);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            txt_LoaiSP.Text = "";
            txt_NCC.Text = "";
            num_SoSP.Value = 0;
            txt_ThongTinSP.Text = "";
            txt_GiaBan.Text = "";
            txt_BaoHanh.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
