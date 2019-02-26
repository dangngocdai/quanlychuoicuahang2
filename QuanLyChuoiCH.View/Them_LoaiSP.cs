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
    public partial class Them_LoaiSP : Form
    {
        private BUS_LoaiSP LSP = new BUS_LoaiSP();
        LoaiSP fLSP = new LoaiSP();
        public Them_LoaiSP(LoaiSP fLSP1)
        {
            InitializeComponent();
            fLSP = fLSP1;
        }

        private void Them_LoaiSP_Load(object sender, EventArgs e)
        {

        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            LSP.insert(txt_MaNhom.Text, txt_TenNhom.Text, Rtxt_ThongTin.Text);
            fLSP.load();
            this.Close();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
