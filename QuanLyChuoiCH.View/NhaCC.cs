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
    public partial class NhaCC : Form
    {
        BUS_NhaCC NCC = new BUS_NhaCC();
        public NhaCC()
        {
            InitializeComponent();
        }

        private void NhaCC_Load(object sender, EventArgs e)
        {
            load();
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void load()
        {
            dataGridView1.DataSource = NCC.GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_Sua.Enabled = true;
            if (NCC.check(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                bt_Xoa.Enabled = true;
            }
        }
        public string layMaNCC()
        {

            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public string layTenNCC()
        {

            return dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public string laySDTNCC()
        {

            return dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        public string layDiaChi()
        {

            return dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (NCC.check(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                NCC.delete(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Nhà Cung Cấp Này!!!!!");
            }
            load();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NCC.TimKiem(txt_TimKiem.Text);
        }

        private void bt_All_Click(object sender, EventArgs e)
        {
            load();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            Them_NhaCC f = new Them_NhaCC(this);
            f.Show();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            Sua_NhaCC f = new Sua_NhaCC(this);
            f.Show();
        }
    }
}
