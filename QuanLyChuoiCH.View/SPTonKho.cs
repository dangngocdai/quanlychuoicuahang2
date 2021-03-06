﻿using System;
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
    public partial class SPTonKho : Form
    {
        BUS_SPTonKho SPTK = new BUS_SPTonKho();
        Kho Kho = new Kho();
        public SPTonKho()
        {
            InitializeComponent();
        }
        public SPTonKho(Kho kho1)
        {
            InitializeComponent();
            Kho = kho1;
        }

        private void SPTonKho_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = SPTK.GetData(Kho.Lay_MaKho());
        }
    }
}
