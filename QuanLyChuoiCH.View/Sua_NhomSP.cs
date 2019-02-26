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
    public partial class Sua_NhomSP : Form
    {
        NhomSP fNSP = new NhomSP();
        BUS_NhomSP NSP = new BUS_NhomSP();
        public Sua_NhomSP(NhomSP fNSP1)
        {
            InitializeComponent();
            fNSP = fNSP1;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            NSP.update(txt_MaNhom.Text, txt_TenNhom.Text, Rtxt_ThongTin.Text);
            fNSP.load();
            this.Close();
        }

        private void Sua_NhomSP_Load(object sender, EventArgs e)
        {
            txt_MaNhom.Text = fNSP.layMaNhomSP();
            txt_TenNhom.Text = fNSP.layTenNhomSP();
            Rtxt_ThongTin.Text = fNSP.layThongTinNhomSP();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
