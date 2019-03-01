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
   public class BUS_CTHDXuatKho
    {
        DAL_CTHDXuatKho c = new DAL_CTHDXuatKho();
        public DataTable GetData()
        {

            return c.GetData();
        }
        public void insertData(String MaHDXuatKho, String MaSP, String SoLuong)
        {

            c.insertData(MaHDXuatKho, MaSP, SoLuong);
        }
        public void update( String MaHDXuatKho, String MaSP, String SoLuong)
        {

            c.update(MaHDXuatKho, MaSP, SoLuong);
        }
        public void delete(String MaCTHDNhapKho)
        {
            c.delete(MaCTHDNhapKho);
        }
    }
}
