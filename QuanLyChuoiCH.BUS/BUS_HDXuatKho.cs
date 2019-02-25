using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public class BUS_HDXuatKho
    {
        DAL_HDXuatKho v = new DAL_HDXuatKho();
        public DataTable GetData()
        {

            return v.GetData();
        }
        public void insertData(String MaHDXuatKho, String MaKho, String MaCH, String NgayXuat, String MaNgQuanLy)
        {
            v.insertData(MaHDXuatKho, MaKho, MaCH, NgayXuat, MaNgQuanLy);
        }
        public void update(String MaHDXuatKho, String MaKho, String MaCH, String NgayXuat, String MaNgQuanLy)
        {
            v.update(MaHDXuatKho, MaKho, MaCH, NgayXuat, MaNgQuanLy);
        }
        public void delete(String MaHDXuatKho)
        {
            v.delete(MaHDXuatKho);
        }
    }
}
