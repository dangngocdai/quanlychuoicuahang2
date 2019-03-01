using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
   public class DAL_HDban : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDBan_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData( String MaHDBan , String MaCH, String MaKH, String NgayBan , String ThongTin , String MaNV)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDBan_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDBan", MaHDBan));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            cmd.Parameters.Add(new SqlParameter("@NgayBan", NgayBan));
            cmd.Parameters.Add(new SqlParameter("@ThongTin", ThongTin));
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaHDBan, String MaCH, String MaKH, String NgayBan, String ThongTin, String MaNV)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDBan_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDBan", MaHDBan));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            cmd.Parameters.Add(new SqlParameter("@NgayBan", NgayBan));
            cmd.Parameters.Add(new SqlParameter("@ThongTin", ThongTin));
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaHDBan)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDBan_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDBan", MaHDBan));
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
