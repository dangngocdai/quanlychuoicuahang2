using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuoiCH.DAL;
namespace QuanLyChuoiCH.BUS
{   
   
    public class BUS_SPTonCH
    {
        DAL_SPTonCH t = new DAL_SPTonCH();
        public DataTable GetData(String MaCH)
        {
            
            return t.GetData(MaCH);
        }
        public void insertData(String MaKho, String MaSP, String SoLuong)
        {

            t.insertData(MaKho, MaSP, SoLuong);
        }
        public void update(String MaKho, String MaSP, String SoLuong)
        {

            t.update(MaKho, MaSP, SoLuong);
        }
        public void delete(String MaKho)
        {
            t.delete(MaKho);
        }
        public int CheckMaSP(String MaSP, String MaCH)
        {
            return t.CheckMaSP(MaSP, MaCH);
        }
        public void ThemSP(String MaCH, String MaSP, String SoLuong)
        {

            t.ThemSP(MaCH, MaSP, SoLuong);
        }
        public void BoSP(String MaCH, String MaSP, String SoLuong)
        {

            t.BoSP(MaCH, MaSP, SoLuong);
        }
        public int CheckSoLuong(String MaCH, String MaSP)
        {
            return t.CheckSoLuong(MaCH, MaSP);
        }
    }
}
