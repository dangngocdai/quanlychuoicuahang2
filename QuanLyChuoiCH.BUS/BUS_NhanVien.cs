using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien e = new DAL_NhanVien();
        public DataTable GetData()
        {

            return e.GetData();
        }
        public void insertData(String MaNV, String TenNV, String MaCH, String ChucVu, String NgayCong, String SDTNV, String MaNgQuanLy)
        {

            e.insertData(MaNV, TenNV, MaCH, ChucVu, NgayCong, SDTNV, MaNgQuanLy);
        }
        public void update(String MaNV, String TenNV, String MaCH, String ChucVu, String NgayCong, String SDTNV, String MaNgQuanLy)
        {

            e.update(MaNV, TenNV, MaCH, ChucVu, NgayCong, SDTNV, MaNgQuanLy);
        }
        public void delete(String MaNV)
        {
            e.delete(MaNV);
        }
    }
}
