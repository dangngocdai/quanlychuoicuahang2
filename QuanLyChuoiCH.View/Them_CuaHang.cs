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
    public partial class Them_CuaHang : Form
    {
        private BUS_CuaHang CH = new BUS_CuaHang();
        private BUS_NgQuanLy QL = new BUS_NgQuanLy();
        private CuaHang CH2 = new CuaHang();
        public Them_CuaHang(CuaHang CH1)
        {
            InitializeComponent();
            CH2 = CH1;
        }

        private void Them_CuaHang_Load(object sender, EventArgs e)
        {
            Cmb_QuanLy.DataSource = QL.getData();
            Cmb_QuanLy.DisplayMember = "TenQuanLy";
            Cmb_QuanLy.ValueMember = "MaNgQuanLy";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            CH.Them_CuaHang(txt_MaCH.Text, txt_TenCH.Text, txt_SDT.Text, txt_DiaChi.Text, Cmb_QuanLy.SelectedValue.ToString());
            //Them_CuaHang(CuaHang.)
            CH2.load();
            this.Close();
        }
    }
}
