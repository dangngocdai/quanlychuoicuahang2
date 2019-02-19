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
    public partial class CuaHang : Form
    {
        private BUS_CuaHang CH = new BUS_CuaHang();
        public CuaHang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
       /* public void getData()
        {
            dataGridView1.DataSource = CH.getdata();
        }*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CuaHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyChuoiCuaHang2DataSet.CuaHang_Lay' table. You can move, or remove it, as needed.
            load();

        }
        public void load()
        {
            this.cuaHang_LayTableAdapter.Fill(this.quanLyChuoiCuaHang2DataSet.CuaHang_Lay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Them_CuaHang T = new Them_CuaHang(this);
            T.Show();
        }
    }
}
