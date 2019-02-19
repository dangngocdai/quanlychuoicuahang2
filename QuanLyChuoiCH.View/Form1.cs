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
    public partial class Form1 : Form
    {
        BUS_kho kho = new BUS_kho();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            dataGridView1.DataSource = kho.getdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);//Khởi tạo from
            f.ShowDialog(); //Show from
        }
    }
}
