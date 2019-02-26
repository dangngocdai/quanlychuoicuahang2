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
    public partial class Them_NhomSP : Form
    {
        private BUS_NhomSP NSP = new BUS_NhomSP();
        NhomSP fNSP = new NhomSP();
        public Them_NhomSP(NhomSP fNSP1)
        {
            InitializeComponent();
            fNSP = fNSP1;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            NSP.insert(txt_MaNhom.Text, txt_TenNhom.Text, Rtxt_ThongTin.Text);
            fNSP.load();
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
