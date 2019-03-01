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
    public partial class SPTonCH : Form
    {
        BUS_SPTonCH TCH = new BUS_SPTonCH();
        CuaHang CH = new CuaHang();
        
        public SPTonCH(CuaHang CH1)
        {
            InitializeComponent();
            CH = CH1;
        }

        private void SPTonCH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TCH.GetData(CH.layMaCH());
        }
        public string LayMaSP()
        {
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void bt_Chon_Click(object sender, EventArgs e)
        {
           // HoaDonBan fHDB = new HoaDonBan(CH);
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
