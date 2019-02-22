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
    }
}
