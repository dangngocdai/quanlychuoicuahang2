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
    public partial class SanPham : Form
    {
        BUS_SP SP = new BUS_SP();

        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            load();
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }
        public void load()
        {
            dataGridView1.DataSource = SP.GetData();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            Them_SanPham f = new Them_SanPham(this);
            f.Show();
        }
        public string layMaSanPham()
        {

            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public string layTenSanPham()
        {

            return dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public string layLoaiSanPham()
        {

            return dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        public string layNhomSanPham()
        {

            return dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        public string layNhaCC()
        {

            return dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        public string layThongTin()
        {

            return dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public string layGiaBan()
        {

            return dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        public string layBaoHanh()
        {

            return dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_Sua.Enabled = true;
            if (SP.Check_MaSP(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0){
                bt_Xoa.Enabled = true;
            };
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            Sua_SanPham f = new Sua_SanPham(this);
            f.Show();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (SP.Check_MaSP(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                SP.delete(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Người Quản Lý Này!!!!!");
            }
            load();
        }

        private void bt_All_Click(object sender, EventArgs e)
        {
            load();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            String Giatri = txt_TimKiem.Text;
            dataGridView1.DataSource = SP.TimKiem(Giatri);
            //this.load();
        }
    }
}
