using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DAL_CuaHang : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CuaHang_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaCH, String TenCH, String SDTCH, String DiaChi, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CuaHang_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@TenCH", TenCH));
            cmd.Parameters.Add(new SqlParameter("@SDTCH", SDTCH));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaCH, String TenCH, String SDTCH, String DiaChi, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CuaHang_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@TenCH", TenCH));
            cmd.Parameters.Add(new SqlParameter("@SDTCH", SDTCH));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        } 
        public void delete(String MaCH)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CuaHang_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int Check_MaCH(String MaCH)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CheckMaCH_HDXuatKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            int kq1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaCH_HDBan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            int kq2= (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaCH_SPTonCH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            int kq3 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaCH_NhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            int kq4 = (int)cmd.ExecuteScalar();
            con.Close();
            int kq = kq1 + kq2 + kq3 + kq4;
            return kq;
        }
}
}
