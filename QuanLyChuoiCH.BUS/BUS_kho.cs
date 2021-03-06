﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyChuoiCH.DAL;
namespace QuanLyChuoiCH.BUS
{
    public class BUS_kho
    {
        DAL_kho d = new DAL_kho();
        public DataTable getdata()
        {
            return d.getData();
        }
        public void insertData(String MaKho, String TenKho, String DiaChi, String SDTKho, String MaNgQuanLy)
        {
            d.insertData(MaKho, TenKho, DiaChi,SDTKho,MaNgQuanLy);
        }
        public void updatetData(String MaKho, String TenKho, String DiaChi, String SDTKho, String MaNgQuanLy)
        {
            d.updateData(MaKho, TenKho, DiaChi, SDTKho, MaNgQuanLy);
        }
        public void delete (String MaKho)
        {
            d.delete(MaKho);
        }
        public int check_MaKho(String MaKho)
        {
            return d.check_MaKho(MaKho);
        }
        public DataTable TimKiem(String GiaTri)
        {
            return d.TimKiem(GiaTri);
        }
    }

}
