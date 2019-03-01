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
        CuaHang fCH = new CuaHang();
        HoaDonBan fHDB;
        public Them_KhachHang(KhachHang fKH1)
        {
            InitializeComponent();
            fKH = fKH1;
        }
        public Them_KhachHang(HoaDonBan fKH1)
        {
            InitializeComponent();
            fHDB = fKH1;
            
        }
        private void Them_KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
           
            KH.insertData(txt_MaSP.Text, txt_TenSP.Text, txt_GiaBan.Text, textBox1.Text);
            if(fHDB != null) {
                fHDB.load();
            };
            if (fKH != null)
            {
                fKH.load();
            };
            //fKH.load();
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
