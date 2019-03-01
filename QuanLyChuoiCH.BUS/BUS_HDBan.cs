using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
    public class BUS_HDBan
    {
        DAL_HDban q = new DAL_HDban();
        public DataTable GetData()
        {

            return q.GetData();
        }
        public void insertData( String MaHDBan, String MaCH, String MaKH, String NgayBan, String ThongTin, String MaNV)
        {

            q.insertData(MaHDBan , MaCH, MaKH, NgayBan, ThongTin,MaNV);
        }
        public void update(String MaHDBan, String MaCH, String MaKH, String NgayBan, String ThongTin, String MaNV)
        {

            q.update(MaHDBan, MaCH, MaKH, NgayBan, ThongTin,MaNV);
        }
        public void delete(String MaHDBan)
        {
            q.delete(MaHDBan);
        }
    } 
}
