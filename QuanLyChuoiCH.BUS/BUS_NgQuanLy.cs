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
    public class BUS_NgQuanLy
    {
        DAL_NgQuanLy QL = new DAL_NgQuanLy();
        public DataTable getData()
        {
            return QL.GetData();
        }
        public void Them_NgQuanLy(String MaNgQuanLy, String TenNgQuanLy, String NamSinh, String QueQuan, String CMND, String SDTQuanLy, String DiaChi)
        {
            QL.insert(MaNgQuanLy, TenNgQuanLy, NamSinh, QueQuan, CMND,SDTQuanLy, DiaChi);
        }
        public void Sua_NgQuanLy(String MaNgQuanLy, String TenNgQuanLy, String NamSinh, String QueQuan, String CMND, String SDTQuanLy, String DiaChi)
        {
            QL.update(MaNgQuanLy, TenNgQuanLy, NamSinh, QueQuan, CMND, SDTQuanLy, DiaChi);
        }
        public void Xoa_NgQuanLy(String MaNgQuanLy)
        {
            QL.delete(MaNgQuanLy);
        }
        public int Check_MaNgQuanLy(String MaNgQuanLy)
        {
            return QL.Check_MaNgQuanLy(MaNgQuanLy);
        }
        public DataTable TimKiem(String GiaTri)
        {
            return QL.TimKiem(GiaTri);
        }
    }
}
