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
    
    public partial class Sua_Kho : Form
    {
        BUS_NgQuanLy QL = new BUS_NgQuanLy();
        BUS_kho K = new BUS_kho();
        Kho fK = new Kho();
        public Sua_Kho(Kho fK1)
        {
            InitializeComponent();
            fK = fK1;
        }

        private void Sua_Kho_Load(object sender, EventArgs e)
        {
            cmb_NgQuanLy.DataSource = QL.getData();
            cmb_NgQuanLy.DisplayMember = "TenQuanLy";
            cmb_NgQuanLy.ValueMember = "MaNgQuanLy";
            txt_MaKho.Text = fK.Lay_MaKho();
            txt_TenKho.Text = fK.Lay_TenKho();
            txt_SDT.Text = fK.Lay_SDTKho();
            Rtxt_DiaChi.Text = fK.Lay_DiaCHiKho();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            K.updatetData(txt_MaKho.Text, txt_TenKho.Text, Rtxt_DiaChi.Text, txt_SDT.Text, cmb_NgQuanLy.SelectedValue.ToString());
            fK.load();
            this.Close();
        }
    }
}
