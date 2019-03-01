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
    }
}
