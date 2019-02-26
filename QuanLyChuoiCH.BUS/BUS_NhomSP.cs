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
    public partial class BUS_NhomSP
    {
        DAL_NhomSP NSP = new DAL_NhomSP();
        public DataTable GetData()
        {
            return NSP.GetData();
        }
        public void insert(String MaNhomSP, String TenNhomSP, String ThongTinNhom)
        {
            NSP.insertData(MaNhomSP, TenNhomSP, ThongTinNhom);
        }
        public void update(String MaNhomSP, String TenNhomSP, String ThongTinNhom)
        {
            NSP.updateData(MaNhomSP, TenNhomSP, ThongTinNhom);
        }
        public void delete(String MaNhomSP)
        {
            NSP.delete(MaNhomSP);
        }
        public int check(String MaNhomSP)
        {
            return NSP.Check(MaNhomSP);
        }
        public DataTable TimKiem(String GiaTri)
        {
            return NSP.TimKiem(GiaTri);
        }
    }
}
