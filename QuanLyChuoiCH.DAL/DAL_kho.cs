using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyChuoiCH.DAL
{
    public class DAL_kho : DBConnect //kế thừa
    {
        public DataTable getData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Kho_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;

        }
        public void insertData(String MaKho, String TenKho, String DiaChi, String SDTKho, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Kho_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@TenKho", TenKho));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SDTKho", SDTKho));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateData(String MaKho, String TenKho, String DiaChi, String SDTKho, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Kho_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@TenKho", TenKho));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SDTKho", SDTKho));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaKho)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Kho_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int check_MaKho(String MaKho)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CheckMaKho_HDNhapKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            int kq1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaKho_HDXuatKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            int kq2 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaKho_SPTonKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            int kq3 = (int)cmd.ExecuteScalar();
            con.Close();
            return kq1 + kq2 + kq3;
        }
        public DataTable TimKiem (String GiaTri)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TimKiem_Kho", con);
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