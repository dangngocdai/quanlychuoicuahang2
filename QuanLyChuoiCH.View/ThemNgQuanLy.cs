﻿using QuanLyChuoiCH.BUS;
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
    public partial class ThemNgQuanLy : Form
    {
        BUS_NgQuanLy QL = new BUS_NgQuanLy();
        NgQuanLy QL1 = new NgQuanLy();
        public ThemNgQuanLy(NgQuanLy QL2)
        {
            InitializeComponent();
            QL1 = QL2;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            QL.Them_NgQuanLy(txt_MaNgQuanLy.Text, txt_TenNgQuanLy.Text, txt_NamSinh.Text, Rtxt_QueQuan.Text, txt_CMND.Text, txt_SDT.Text, Rtxt_DiaChi.Text);
            QL1.load();
            this.Close();
        }
    }
}
