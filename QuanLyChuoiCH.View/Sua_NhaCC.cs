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
    public partial class Sua_NhaCC : Form
    {
        BUS_NhaCC NCC = new BUS_NhaCC();
        NhaCC fNCC = new NhaCC();
        public Sua_NhaCC(NhaCC fNCC1 )
        {
            InitializeComponent();
            fNCC = fNCC1;
        }

        private void Sua_NhaCC_Load(object sender, EventArgs e)
        {
            txt_MaNCC.Text = fNCC.layMaNCC();
            txt_TenNCC.Text = fNCC.layTenNCC();
            txt_SDT.Text = fNCC.laySDTNCC();
            txt_DiaChi.Text = fNCC.layDiaChi();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            NCC.update(txt_MaNCC.Text, txt_TenNCC.Text, txt_SDT.Text, txt_DiaChi.Text);
            fNCC.load();
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
