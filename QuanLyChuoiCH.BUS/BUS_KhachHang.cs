using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

public namespace QuanLyChuoiCH.BUS
{
    class BUS_KhachHang
    {
        DAL_KhachHang b = new DAL_KhachHang();
        public DataTable GetData()
        {

            return b.GetData();
        }
        public void insertData(String MaKH, String TenKH, String SDTKH, String SoHD)
        {

            b.insertData(MaKH, TenKH, SDTKH, SoHD);
        }
        public void update(String MaKH, String TenKH, String SDTKH, String SoHD)
        {


            b.update(MaKH, TenKH, SDTKH, SoHD);
        }
        public void delete(String MaKH)
        {
            b.delete(MaKH);
        }
    }
}
