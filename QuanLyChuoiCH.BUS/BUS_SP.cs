using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public partial class BUS_SP
    {
        DAL_SanPham o = new DAL_SanPham();
        public DataTable GetData()
        {

            return o.GetData();
        }
        public void insertData(String MaSP, String TenSP, String MaLoaiSP, String MaNCC, String ThongTinSP, String GiaBan, String BaoHanh)
        {
            o.insertData(MaSP, TenSP, MaLoaiSP, MaNCC, ThongTinSP, GiaBan, BaoHanh);
        }
        public void update(String MaSP, String TenSP, String MaLoaiSP, String MaNCC, String ThongTinSP, String GiaBan, String BaoHanh)
        {
            o.update(MaSP, TenSP, MaLoaiSP, MaNCC, ThongTinSP, GiaBan, BaoHanh);
        }
        public void delete(String MaSP)
        {
            o.delete(MaSP);
        }
        public int Check_MaSP(String MaSP)
        {
            return o.Check_MaSP(MaSP);
        }
        public DataTable TimKiem(String Giatri)
        {

            return o.TimKiem(Giatri);
        }
        public string TenSP(String MaSP)
        {
            return o.TenSP(MaSP);
        }
        public string LoaiSP(String MaSP)
        {
            return o.LoaiSP(MaSP);
        }
        public string NhaCC(String MaSP)
        {
            return o.NhaCC(MaSP);
        }
        public string ThongTin(String MaSP)
        {
            return o.ThongTin(MaSP);
        }
        public string GiaBan(String MaSP)
        {
            return o.GiaBan(MaSP);
        }
        public string BaoHanh(String MaSP)
        {
            return o.BaoHanh(MaSP);
        }
    }
}
