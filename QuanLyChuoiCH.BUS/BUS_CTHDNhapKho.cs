using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public class BUS_CTHDNhapKho
    {
        DAL_CTHDNhapKho c = new DAL_CTHDNhapKho();
        public DataTable GetData()
        {

            return c.GetData();
        }
        public void insertData(String MaCTHDNhapKho, String MaHDNhapKho, String MaSP, String SoLuong, String GiaNhap)
        {

            c.insertData(MaCTHDNhapKho, MaHDNhapKho, MaSP, SoLuong, GiaNhap);
        }
        public void update(String MaCTHDNhapKho, String MaHDNhapKho, String MaSP, String SoLuong, String GiaNhap)
        {

            c.update(MaCTHDNhapKho, MaHDNhapKho, MaSP, SoLuong, GiaNhap);
        }
        public void delete(String MaCTHDNhapKho)
        {
            c.delete(MaCTHDNhapKho);
        }
    }
}
