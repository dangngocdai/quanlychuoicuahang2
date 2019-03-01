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
    public partial class XuatKho : Form
    {
        BUS_SPTonKho SPTK = new BUS_SPTonKho();
        BUS_CuaHang CH = new BUS_CuaHang();
        BUS_NgQuanLy NgQL = new BUS_NgQuanLy();
        Kho kho = new Kho();
        BUS_SP SP = new BUS_SP();
        BUS_HDXuatKho HDXK = new BUS_HDXuatKho();
        BUS_CTHDXuatKho CTHDXK = new BUS_CTHDXuatKho();
        BUS_SPTonCH SPTCH = new BUS_SPTonCH();
        public XuatKho()
        {
            InitializeComponent();
        }
        public XuatKho(Kho kho1)
        {
            InitializeComponent();
            kho = kho1;
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load() {
            cmb_MaSP.DataSource = SPTK.GetData(kho.layMaKho());
            cmb_MaSP.DisplayMember = "MaSP";
            cmb_MaSP.ValueMember = "MaSP";
            txt_Kho.Text = kho.layMaKho();
            cmb_CH.DataSource = CH.getdata();
            cmb_CH.DisplayMember = "TenCH";
            cmb_CH.ValueMember = "MaCH";
            cmb_NgQuanLy.DataSource = NgQL.getData();
            cmb_NgQuanLy.DisplayMember = "TenQuanLy";
            cmb_NgQuanLy.ValueMember = "MaNgQuanLy";
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

        private void num_SoSP_ValueChanged(object sender, EventArgs e)
        {
            if(SPTK.CheckSoLuong(kho.layMaKho(), cmb_MaSP.SelectedValue.ToString()) < num_SoSP.Value)
            {
                MessageBox.Show("Số Lượng Vượt Quá Sản Phẩm Trong Kho");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int giaban = (int)num_SoSP.Value * Int32.Parse(txt_GiaBan.Text);
            dataGridView1.Rows.Add(cmb_MaSP.SelectedValue.ToString(), txt_TenSP.Text, txt_LoaiSP.Text, num_SoSP.Value, giaban);
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
            HDXK.insertData(txt_MaHD.Text, txt_Kho.Text, cmb_CH.SelectedValue.ToString(), date(), cmb_NgQuanLy.SelectedValue.ToString());
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //MessageBox.Show(" " + dataGridView1.Rows[i].Cells[0]);
                string MaHDBan = txt_MaHD.Text;
                string GiaNhap = dataGridView1.Rows[i].Cells[4].Value.ToString();
                string cotMaSP = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string cotSoLuong = dataGridView1.Rows[i].Cells[3].Value.ToString();
                CTHDXK.insertData(MaHDBan, cotMaSP, cotSoLuong);
                if (SPTCH.CheckMaSP(cotMaSP, cmb_CH.SelectedValue.ToString()) == 0)
                {
                    SPTK.BoSP(cmb_CH.SelectedValue.ToString(), cotMaSP, cotSoLuong);
                    SPTCH.insertData(cmb_CH.SelectedValue.ToString(), cotMaSP, cotSoLuong);
                }
                else
                {
                    SPTK.BoSP(cmb_CH.SelectedValue.ToString(), cotMaSP, cotSoLuong);
                    SPTCH.ThemSP(cmb_CH.SelectedValue.ToString(), cotMaSP, cotSoLuong);

                }

            }

            kho.load();
            this.Close();
        }

        private void bt_ThemNCC_Click(object sender, EventArgs e)
        {
            Them_CuaHang f = new Them_CuaHang(this);
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemNgQuanLy fTNCC = new ThemNgQuanLy(this);
            fTNCC.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
