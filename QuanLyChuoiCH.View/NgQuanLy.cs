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
    public partial class NgQuanLy : Form
    {
        BUS_NgQuanLy QL = new BUS_NgQuanLy();
        
        public NgQuanLy()
        {
            
            InitializeComponent();
        }

        private void NgQuanLy_Load(object sender, EventArgs e)
        {
            load();
            button2.Enabled = false;
            button3.Enabled = false;
        }
        public void load()
        {
            dataGridView1.DataSource = QL.getData();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = QL.TimKiem(txt_TimKiem.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNgQuanLy f = new ThemNgQuanLy(this);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sua_NgQuanLy f = new Sua_NgQuanLy(this);
            f.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            button2.Enabled = true;
            if(QL.Check_MaNgQuanLy(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                button3.Enabled = true;
            }
        }
        public string layMaNgQL()
        {
            
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public string layTenNgQL()
        {
            string ma = dataGridView1.CurrentRow.Cells[1].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string layNamSinh()
        {
            string ma = dataGridView1.CurrentRow.Cells[2].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string layQueQuan()
        {
            string ma = dataGridView1.CurrentRow.Cells[3].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string layCMND()
        {
            string ma = dataGridView1.CurrentRow.Cells[4].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string laySDT()
        {
            string ma = dataGridView1.CurrentRow.Cells[5].Value.ToString();//lay ma cua hang
            return ma;
        }
        public string layDiaChi()
        {
            string ma = dataGridView1.CurrentRow.Cells[6].Value.ToString();//lay ma cua hang
            return ma;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (QL.Check_MaNgQuanLy(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                QL.Xoa_NgQuanLy(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Người Quản Lý Này!!!!!");
            }
            load();
        }

        private void bt_All_Click(object sender, EventArgs e)
        {
            this.load();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
