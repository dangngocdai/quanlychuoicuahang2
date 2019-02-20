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
    public partial class Form2 : Form
    {
        private BUS_kho kho = new BUS_kho();
        private SuaCuaHang frm = null;
        public Form2(SuaCuaHang _frm)
        {
            InitializeComponent();
            frm = _frm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // kho.insertData(txt_MaKho.Text, txt_TenKho.Text, Txt_DiaChi.Text, Txt_SDTKho.Text, Txt_MaNgQuanLy.Text);
            //frm.getData();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
