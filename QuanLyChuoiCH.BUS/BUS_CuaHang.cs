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
        DAL_CuaHang d = new DAL_CuaHang();

        public object ThemCuaHang { get; set; }

        public DataTable getdata()
        {
            return d.GetData();
        }
    public void Them_CuaHang(String MaCH, String TenCH, String SDTCH, String DiaChi, String MaNgQuanLy)
        {
            d.insertData(MaCH, TenCH, SDTCH, DiaChi, MaNgQuanLy);
        }
    }
}
