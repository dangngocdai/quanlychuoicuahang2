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
    public partial class SPTonCH : Form
    {
        BUS_SPTonCH TCH = new BUS_SPTonCH();
        CuaHang CH = new CuaHang();
        HoaDonBan f;
        
        public SPTonCH(CuaHang CH1)
        {
            InitializeComponent();
            CH = CH1;
        }
        public SPTonCH(HoaDonBan CH1)
        {
            InitializeComponent();
            f = CH1;
        }
        private void SPTonCH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TCH.GetData(f.macuahang);
        }
        public string LayMaSP()
        {
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void bt_Chon_Click(object sender, EventArgs e)
        {
           // HoaDonBan fHDB = new HoaDonBan(CH);
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("MaSP = '{0}'", txt_TimKiem.Text);
            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txt_TimKiem.Text) ?
                    "lename IS NOT NULL" :
                    String.Format("MaSP LIKE '{0}' OR Tensp LIKE '{1}'", txt_TimKiem.Text, txt_TimKiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            f.add(dataGridView1.CurrentRow.Cells[0].Value.ToString()/*MaSP*/ , dataGridView1.CurrentRow.Cells[1].Value.ToString()/*TenSP*/, dataGridView1.CurrentRow.Cells[4].Value.ToString()/*LoaiSP*/, dataGridView1.CurrentRow.Cells[5].Value.ToString()/*NCC*/, dataGridView1.CurrentRow.Cells[6].Value.ToString()/*thongtin*/, dataGridView1.CurrentRow.Cells[3].Value.ToString()/*Giaban*/, dataGridView1.CurrentRow.Cells[7].Value.ToString()/*baoHanh*/);
            //string MaSP,string TenSP, string LoaiSP, string NCC, string ThongTin, string GiaBan, string BaoHanh
            this.Close();
        }
    }
}
