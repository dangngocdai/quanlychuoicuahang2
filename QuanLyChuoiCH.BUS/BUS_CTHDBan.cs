using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
   public class BUS_CTHDBan
    {
        DAL_CTHDBan m = new DAL_CTHDBan();
        public DataTable GetData()
        {

            return m.GetData();
        }
        public void insertData(String MaHDBan, String MaSP, String SoLuong)
        {

            m.insertData( MaHDBan, MaSP, SoLuong);
        }
        public void update(String MaCTHDBan, String MaHDBan, String MaSP, String SoLuong)
        {

            m.update(MaCTHDBan, MaHDBan, MaSP, SoLuong);
        }
        public void delete(String MaCTHDBan)
        {
            m.delete(MaCTHDBan);
        }
    }
}
