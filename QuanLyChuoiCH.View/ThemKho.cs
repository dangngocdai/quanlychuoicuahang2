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
    public partial class ThemKho : Form
    {
        BUS_NgQuanLy QL = new BUS_NgQuanLy();
        BUS_kho K = new BUS_kho();
        Kho fK = new Kho();
        NhapKho fNK;
        public ThemKho(Kho fK1)
        {
            InitializeComponent();
            fK = fK1;

        }
        public ThemKho(NhapKho fK1)
        {
            InitializeComponent();
            fNK = fK1;

        }
        public ThemKho()
        {
            InitializeComponent();
            

        }

        private void ThemKho_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            cmb_NgQuanLy.DataSource = QL.getData();
            cmb_NgQuanLy.DisplayMember = "TenQuanLy";
            cmb_NgQuanLy.ValueMember = "MaNgQuanLy";
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            K.insertData(txt_MaKho.Text, txt_TenKho.Text, Rtxt_DiaChi.Text,txt_SDT.Text, cmb_NgQuanLy.SelectedValue.ToString());
            if (fNK != null)
            {
                fNK.load();
            };
            if (fK != null)
            {
                fK.load();
            };
            //fK.load();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemNgQuanLy f = new ThemNgQuanLy(this);
            f.ShowDialog();
        }
    }
}
