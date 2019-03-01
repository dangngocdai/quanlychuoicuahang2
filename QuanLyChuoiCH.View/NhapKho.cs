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
    public partial class NhapKho : Form
    {
        BUS_SP SP = new BUS_SP();
        BUS_kho Kho = new BUS_kho();
        BUS_NhaCC NCC = new BUS_NhaCC();
        BUS_NgQuanLy NQL = new BUS_NgQuanLy();
        BUS_HDNhapKho HDNK = new BUS_HDNhapKho();
        BUS_CTHDNhapKho CTHDNK = new BUS_CTHDNhapKho();
        BUS_SPTonKho SPTK = new BUS_SPTonKho();
        Kho fKho = new Kho();
        public NhapKho(Kho fKho1)
        {
            InitializeComponent();
            fKho = fKho1;
        }
        public NhapKho()
        {
            InitializeComponent();
            
        }
        private void NhapKho_Load(object sender, EventArgs e)
        {
            /*cmb_MaSP.DataSource = SP.GetData();
            cmb_MaSP.DisplayMember = "MaSP";
            cmb_MaSP.ValueMember = "MaSP";
            cmb_MaKho.DataSource = Kho.getdata();
            cmb_MaKho.DisplayMember = "TenKho";
            cmb_MaKho.ValueMember = "MaKho";
            cmb_NCC.DataSource = NCC.GetData();
            cmb_NCC.DisplayMember = "TenNCC";
            cmb_NCC.ValueMember = "MaNCC";
            cmb_NgQuanLy.DataSource = NQL.getData();
            cmb_NgQuanLy.DisplayMember = "TenQuanLy";
            cmb_NgQuanLy.ValueMember = "MaNgQuanLy";*/
            load();
        }
        
        public void load()
        {
            cmb_MaSP.DataSource = SP.GetData();
            cmb_MaSP.DisplayMember = "MaSP";
            cmb_MaSP.ValueMember = "MaSP";
            cmb_MaKho.DataSource = Kho.getdata();
            cmb_MaKho.DisplayMember = "TenKho";
            cmb_MaKho.ValueMember = "MaKho";
            cmb_NCC.DataSource = NCC.GetData();
            cmb_NCC.DisplayMember = "TenNCC";
            cmb_NCC.ValueMember = "MaNCC";
            cmb_NgQuanLy.DataSource = NQL.getData();
            cmb_NgQuanLy.DisplayMember = "TenQuanLy";
            cmb_NgQuanLy.ValueMember = "MaNgQuanLy";
        }
        public void addsp()
        {
            
        }

        private void cmb_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_TenSP.Text = SP.TenSP(cmb_MaSP.SelectedValue.ToString());
            txt_LoaiSP.Text = SP.LoaiSP(cmb_MaSP.SelectedValue.ToString());
            txt_ThongTinSP.Text = SP.ThongTin(cmb_MaSP.SelectedValue.ToString());
            txt_GiaBan.Text = SP.GiaBan(cmb_MaSP.SelectedValue.ToString());
            txt_NCC.Text = SP.NhaCC(cmb_MaSP.SelectedValue.ToString());
            txt_BaoHanh.Text = SP.BaoHanh(cmb_MaSP.SelectedValue.ToString());
        }

        private void bt_ThemSP_Click(object sender, EventArgs e)
        {
            Them_SanPham fTSP = new Them_SanPham(this);
            fTSP.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gianhap = (int)num_SoSP.Value * Int32.Parse(txt_GiaNhap.Text);
           dataGridView1.Rows.Add(cmb_MaSP.Text, txt_TenSP.Text, txt_LoaiSP.Text, num_SoSP.Value, gianhap, txt_GiaBan.Text);
        }

        private void bt_ThemCH_Click(object sender, EventArgs e)
        {
            ThemKho fTK = new ThemKho(this);
            fTK.ShowDialog();
        }


        private void bt_ThemNCC_Click(object sender, EventArgs e)
        {
            Them_NhaCC fTNCC = new Them_NhaCC(this);
            fTNCC.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemNgQuanLy fTNCC = new ThemNgQuanLy(this);
            fTNCC.ShowDialog();
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
            
            HDNK.insertData(txt_MaHD.Text, cmb_MaKho.SelectedValue.ToString(), date(), cmb_NCC.SelectedValue.ToString(), cmb_NgQuanLy.SelectedValue.ToString());
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //MessageBox.Show(" " + dataGridView1.Rows[i].Cells[0]);
                string MaHDBan = txt_MaHD.Text;
                string GiaNhap = dataGridView1.Rows[i].Cells[4].Value.ToString();
                string cotMaSP = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string cotSoLuong = dataGridView1.Rows[i].Cells[3].Value.ToString();
                CTHDNK.insertData(MaHDBan, cotMaSP, cotSoLuong,GiaNhap);
                if(SPTK.CheckMaSP(cotMaSP, cmb_MaKho.SelectedValue.ToString()) == 0)
                {
                    SPTK.insertData(cmb_MaKho.SelectedValue.ToString(), cotMaSP, cotSoLuong);
                }
                else
                {
                    SPTK.ThemSP(cmb_MaKho.SelectedValue.ToString(), cotMaSP, cotSoLuong);
                }

            }

            fKho.load();
            this.Close();

        }
    }
}
