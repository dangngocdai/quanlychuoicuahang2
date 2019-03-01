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
    public partial class ThongKe : Form
    {
        BUS_HDNhapKho HDNK = new BUS_HDNhapKho();
        BUS_HDXuatKho HDXK = new BUS_HDXuatKho();
        BUS_HDBan HDB = new BUS_HDBan();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = HDNK.GetData();
            dataGridView2.DataSource = HDXK.GetData();
            dataGridView3.DataSource = HDB.GetData();
        }
    }
}
