using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DAL_NgQuanLy:DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NgQuanLy_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insert(String MaNgQuanLy, String TenNgQuanLy, String NamSinh, String QueQuan, String CMND, String SDTQuanLy, String DiaChi)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NgQuanLy_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.Parameters.Add(new SqlParameter("@TenQuanLy", TenNgQuanLy));
            cmd.Parameters.Add(new SqlParameter("@NamSinh", NamSinh));
            cmd.Parameters.Add(new SqlParameter("@QueQuan", QueQuan));
            cmd.Parameters.Add(new SqlParameter("@CMND", CMND));
            cmd.Parameters.Add(new SqlParameter("@SDTQuanLy", SDTQuanLy));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaNgQuanLy, String TenNgQuanLy, String NamSinh, String QueQuan, String CMND, String SDTQuanLy, String DiaChi)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NgQuanLy_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.Parameters.Add(new SqlParameter("@TenQuanLy", TenNgQuanLy));
            cmd.Parameters.Add(new SqlParameter("@NamSinh", NamSinh));
            cmd.Parameters.Add(new SqlParameter("@QueQuan", QueQuan));
            cmd.Parameters.Add(new SqlParameter("@CMND", CMND));
            cmd.Parameters.Add(new SqlParameter("@SDTQuanLy", SDTQuanLy));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NgQuanLy_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int Check_MaNgQuanLy(String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CheckMaNgQuanLy_Kho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            int kq1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaNgQuanLy_NhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            int kq2 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaNgQuanLy_CuaHang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            int kq3 = (int)cmd.ExecuteScalar();
            con.Close();
            return kq3;
        }
        public DataTable TimKiem(String GiaTri)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TimKiem_NgQuanLy", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@GiaTri", GiaTri));
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);

            con.Close();
            return tb;
        }
    }
}
