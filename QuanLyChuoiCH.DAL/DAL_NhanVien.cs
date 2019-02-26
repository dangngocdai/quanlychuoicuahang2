using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhanVien_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaNV, String TenNV, String MaCH, String ChucVu, String NgayCong , String SDTNV, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhanVien_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.Parameters.Add(new SqlParameter("@TenNV", TenNV));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@ChucVu", ChucVu));
            cmd.Parameters.Add(new SqlParameter("@NgayCong", NgayCong));
            cmd.Parameters.Add(new SqlParameter("@SDTNV", SDTNV));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaNV, String TenNV, String MaCH, String ChucVu, String NgayCong , String SDTNV, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhanVien_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.Parameters.Add(new SqlParameter("@TenNV", TenNV));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@ChucVu", ChucVu));
            cmd.Parameters.Add(new SqlParameter("@NgayCong", NgayCong));
            cmd.Parameters.Add(new SqlParameter("@SDTNV", SDTNV));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaNV)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhanVien_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
