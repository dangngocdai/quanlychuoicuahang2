using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public class BUS_SPTonKho
    {
        DAL_SPTonKho t = new DAL_SPTonKho();
        public DataTable GetData(String MaCH)
        {

            return t.GetData(MaCH);
        }
        public void insertData(String MaKho, String MaSP, String SoLuong)
        {

            t.insertData(MaKho, MaSP, SoLuong);
        }
        public void ThemSP(String MaKho, String MaSP, String SoLuong)
        {

            t.ThemSP(MaKho, MaSP, SoLuong);
        }
        public void BoSP(String MaKho, String MaSP, String SoLuong)
        {

            t.BoSP(MaKho, MaSP, SoLuong);
        }
        public void delete(String MaKho)
        {
            t.delete(MaKho);
        }
        public int CheckMaSP(String MaSP, String MaKho)
        {
            return t.CheckMaSP(MaSP, MaKho);
        }
        public int CheckSoLuong(String MaKho, String MaSP)
        {
            return t.CheckSoLuong(MaKho, MaSP);
        }
    }
}
