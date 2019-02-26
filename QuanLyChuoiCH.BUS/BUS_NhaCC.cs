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
   public partial class BUS_NhaCC
    {
        DAL_NhaCC NCC = new DAL_NhaCC();
        public DataTable GetData()
        {
            return NCC.GetData();
        }
        public void insert(String MaNCC, String TenNCC, String SDTNCC, String DiaChi)
        {
            NCC.insertData(MaNCC, TenNCC, SDTNCC, DiaChi);
        }
        public void update(String MaNCC, String TenNCC, String SDTNCC, String DiaChi)
        {
            NCC.updateData(MaNCC, TenNCC, SDTNCC, DiaChi);
        }
        public void delete(String MaNCC)
        {
            NCC.delete(MaNCC);
        }
        public int check(String MaNCC)
        {
            return NCC.Check(MaNCC);
        }
        public DataTable TimKiem(String GiaTri)
        {
            return NCC.TimKiem(GiaTri);
        }
    }
}
