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
    public partial class Kho : Form
    {
        BUS_kho K = new BUS_kho();
        public Kho()
        {
            InitializeComponent();
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            load();
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void load()
        {
            dataGridView1.DataSource = K.getdata();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemKho f = new ThemKho(this);
            f.Show();
        }
        public string Lay_MaKho()
        {
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public string Lay_TenKho()
        {
            return dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public string Lay_SDTKho()
        {
            return dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        public string Lay_DiaCHiKho()
        {
            return dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            Sua_Kho f = new Sua_Kho(this);
            f.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_Sua.Enabled = true;
            if (K.check_MaKho(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                bt_Xoa.Enabled = true;
            };
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (K.check_MaKho(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                K.delete(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Kho Này!!!!!");
            }
            load();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = K.TimKiem(txt_TimKiem.Text);
        }

        private void bt_All_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
