using QuanLyChuoiCH.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiCH.View
{
    public partial class KhachHang : Form
    {
        private BUS_KhachHang KH = new BUS_KhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            load();
            bt_Sua.Enabled = false;
        }
        public void load()
        {
            dataGridView1.DataSource = KH.GetData();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            Them_KhachHang f = new Them_KhachHang(this);
            f.Show();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            Sua_KhachHang f = new Sua_KhachHang(this);
            f.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_Sua.Enabled = true;
        }
        public string Lay_MaKH()
        {
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public string Lay_TenKH()
        {
            return dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public string Lay_SDTKH()
        {
            return dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        public string Lay_SoHDKH()
        {
            return dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
