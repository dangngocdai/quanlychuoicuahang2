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
    public partial class LoaiSP : Form
    {
        BUS_LoaiSP LSP = new BUS_LoaiSP();
        public LoaiSP()
        {
            InitializeComponent();
        }
        private void LoaiSP_Load(object sender, EventArgs e)
        {
            load();
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void load()
        {
            dataGridView1.DataSource = LSP.GetData();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            Them_LoaiSP f = new Them_LoaiSP(this);
            f.Show();
        }
        public string layMaLoaiSP()
        {

            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public string layTenLoaiSP()
        {

            return dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public string layThongTinLoaiSP()
        {

            return dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_Sua.Enabled = true;
            if (LSP.check(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                bt_Xoa.Enabled = true;
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            Sua_LoaiSP f = new Sua_LoaiSP(this);
            f.Show();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (LSP.check(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                LSP.delete(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Loại Sản Phẩm Này!!!!!");
            }
            load();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LSP.TimKiem(txt_TimKiem.Text);
        }

        private void bt_All_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
