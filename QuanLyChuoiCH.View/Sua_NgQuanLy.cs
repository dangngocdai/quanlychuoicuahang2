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
    public partial class Sua_NgQuanLy : Form
    {
        NgQuanLy QL = new NgQuanLy();
        BUS_NgQuanLy QL2 = new BUS_NgQuanLy();

        public Sua_NgQuanLy(NgQuanLy QL1)
        {
            InitializeComponent();
            QL = QL1;
        }

        private void Sua_NgQuanLy_Load(object sender, EventArgs e)
        {
            txt_MaNgQuanLy.Text = QL.layMaNgQL();
            txt_TenNgQuanLy.Text = QL.layTenNgQL();
            string[] namsinh = QL.layNamSinh().Split(' ');
            txt_NamSinh.Text = namsinh[0];
            Rtxt_QueQuan.Text = QL.layQueQuan();
            txt_CMND.Text = QL.layCMND();
            txt_SDT.Text = QL.laySDT();
            Rtxt_DiaChi.Text = QL.layDiaChi();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            QL2.Sua_NgQuanLy(txt_MaNgQuanLy.Text, txt_TenNgQuanLy.Text, txt_NamSinh.Text, Rtxt_QueQuan.Text, txt_CMND.Text, txt_SDT.Text, Rtxt_DiaChi.Text);
            QL.load();
            this.Close();
        }
    }
}
