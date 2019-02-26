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
    public partial class Them_NhaCC : Form
    {
        BUS_NhaCC NCC = new BUS_NhaCC();
        NhaCC fNCC = new NhaCC();
        public Them_NhaCC(NhaCC fNCC1)
        {
            InitializeComponent();
            fNCC = fNCC1;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            NCC.insert(txt_MaNCC.Text, txt_TenNCC.Text, txt_SDT.Text, txt_DiaChi.Text);
            fNCC.load();
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
