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
    public partial class SuaCuaHang : Form
    {
        private BUS_CuaHang CH = new BUS_CuaHang();
        private BUS_NgQuanLy QL = new BUS_NgQuanLy();
        private CuaHang CH2 = new CuaHang();
        public SuaCuaHang(CuaHang CH1)
        {
            InitializeComponent();
            CH2 = CH1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cmb_QuanLy.DataSource = QL.getData();
            Cmb_QuanLy.DisplayMember = "TenQuanLy";
            Cmb_QuanLy.ValueMember = "MaNgQuanLy";          
            textBox1.Text = CH2.layMaCH();
            textBox2.Text = CH2.layTenCH();
            textBox3.Text = CH2.laySDTCH();
            richTextBox1.Text = CH2.layDiaChiCH();
            Cmb_QuanLy.DisplayMember = CH2.layNgQLCH();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CH.Sua_CuaHang(textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text, Cmb_QuanLy.SelectedValue.ToString());
            //Sua_CuaHang(CuaHang.)
            CH2.load();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
