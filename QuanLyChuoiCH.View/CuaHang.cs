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
            int kq = CH.Check_MaCH(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (kq == 0)
            {
                CH.Xoa_CuaHang(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Cửa Hàng");
            }
            this.load();
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
            button3.Enabled = false;
            button4.Enabled = false;
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

        private void button3_Click(object sender, EventArgs e)
        {   
            SuaCuaHang f = new SuaCuaHang(this);
            f.Show();
        }
        public string layMaCH()
        {
            string ma = dataGridView1.CurrentRow.Cells[0].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string layTenCH()
        {
            string ma = dataGridView1.CurrentRow.Cells[1].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string laySDTCH()
        {
            string ma = dataGridView1.CurrentRow.Cells[2].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string layDiaChiCH()
        {
            string ma = dataGridView1.CurrentRow.Cells[3].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string layNgQLCH()
        {
            string ma = dataGridView1.CurrentRow.Cells[4].Value.ToString();//lay ma cua hang
            return ma;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;
            int kq = CH.Check_MaCH(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (kq == 0)
            {
                button4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Giatri = textBox1.Text;
            dataGridView1.DataSource = CH.TimKiem(Giatri);
           // this.load();
        }
    }
}
