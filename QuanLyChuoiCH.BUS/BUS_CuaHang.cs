using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public class BUS_CuaHang
    {
        DAL_CuaHang d = new DAL_CuaHang();//dda

        public object ThemCuaHang { get; set; }

        public DataTable getdata()
        {
            return d.GetData();
        }
    public void Them_CuaHang(String MaCH, String TenCH, String SDTCH, String DiaChi, String MaNgQuanLy)
        {
            d.insertData(MaCH, TenCH, SDTCH, DiaChi, MaNgQuanLy);
        }
    public void Sua_CuaHang(String MaCH, String TenCH, String SDTCH, String DiaChi, String MaNgQuanLy)
       {
            d.update(MaCH, TenCH, SDTCH, DiaChi, MaNgQuanLy);
        }
    public void Xoa_CuaHang( String MaCH)
        {
            d.delete(MaCH);
        }
    public int Check_MaCH(String MaCH)
        {
            int kq = d.Check_MaCH(MaCH);
            return kq;
        }
    
    public DataTable TimKiem(String GiaTri)
    {
        return d.TimKiem(GiaTri);
    }
    }
}
