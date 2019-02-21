﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    class BUS_SP
    {
        QuanLyChuoiCH.DAL.DAL_SanPham o = new DAL_SanPham();
        public DataTable GetData()
        {
           
            return o.GetData();
        }
        public void insertData(String MaSP, String TenSP, String MaLoaiSP, String MaNhomSP, String MaNCC, String ThongTinSP, String GiaBan, String BaoHanh)
        {
            o.insertData(MaSP, TenSP, MaLoaiSP, MaNhomSP, MaNCC, ThongTinSP, GiaBan, BaoHanh);
        }
        public void update(String MaSP, String TenSP, String MaLoaiSP, String MaNhomSP, String MaNCC, String ThongTinSP, String GiaBan, String BaoHanh)
        {
            o.update(MaSP, TenSP, MaLoaiSP, MaNhomSP, MaNCC, ThongTinSP, GiaBan, BaoHanh);
        }
        public void delete(String MaSP)
        {
            o.delete(MaSP);
        }
    }