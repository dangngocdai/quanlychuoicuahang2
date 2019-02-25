using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public class BUS_HDNhapKho
    {
        DAL_HDNhapKho x = new DAL_HDNhapKho();
        public DataTable GetData()
        {

            return x.GetData();
        }
        public void insertData(String MaHDNhapKho, String MaKho, String NgayNhap, String MaNCC, String MaNgQuanLy)
        {

            x.insertData(MaHDNhapKho, MaKho, NgayNhap, MaNCC, MaNgQuanLy);
        }
        public void update(String MaHDNhapKho, String MaKho, String NgayNhap, String MaNCC, String MaNgQuanLy)
        {

            x.update(MaHDNhapKho, MaKho, NgayNhap, MaNCC, MaNgQuanLy);

        }
        public void delete(String MaHDNhapKho)
        {
            x.delete(MaHDNhapKho);
        }

    }
}
