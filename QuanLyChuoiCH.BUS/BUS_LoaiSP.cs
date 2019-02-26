using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuoiCH.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.BUS
{
    public partial class BUS_LoaiSP
    {
        DAL_LoaiSP LSP = new DAL_LoaiSP();
       public DataTable GetData()
        {
            return LSP.GetData();
        }
        public void insert(String MaLoaiSP, String TenLoaiSP, String ThongTinLoai)
        {
            LSP.insertData(MaLoaiSP, TenLoaiSP, ThongTinLoai);
        }
        public void update(String MaLoaiSP, String TenLoaiSP, String ThongTinLoai)
        {
            LSP.updateData(MaLoaiSP, TenLoaiSP, ThongTinLoai);
        }
        public void delete (String MaLoaiSP)
        {
            LSP.delete(MaLoaiSP);
        }
        public int check(String MaLoaiSP)
        {
            return LSP.Check(MaLoaiSP);
        }
        public DataTable TimKiem(String GiaTri)
        {
            return LSP.TimKiem(GiaTri);
        }
    }
}
