using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("KhachHang_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaKH, String TenKH, String SDTKH, String SoHD)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("KhachHang_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            cmd.Parameters.Add(new SqlParameter("@TenKH", TenKH));
            cmd.Parameters.Add(new SqlParameter("@SDTKH", SDTKH));
            cmd.Parameters.Add(new SqlParameter("@SoHD", SoHD));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaKH, String TenKH, String SDTKH, String SoHD)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("KhachHang_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            cmd.Parameters.Add(new SqlParameter("@TenKH", TenKH));
            cmd.Parameters.Add(new SqlParameter("@SDTKH", SDTKH));
            cmd.Parameters.Add(new SqlParameter("@SoHD", SoHD));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaKH)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("KhachHang_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
