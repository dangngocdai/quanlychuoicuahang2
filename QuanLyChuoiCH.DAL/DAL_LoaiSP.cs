using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyChuoiCH.DAL
{
    public partial class DAL_LoaiSP:DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("LoaiSP_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaLoaiSP, String TenLoaiSP, String ThongTinLoai)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("LoaiSP_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
            cmd.Parameters.Add(new SqlParameter("@TenLoaiSP", TenLoaiSP));
            cmd.Parameters.Add(new SqlParameter("@ThongTinLoai", ThongTinLoai));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateData(String MaLoaiSP, String TenLoaiSP, String ThongTinLoai)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("LoaiSP_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
            cmd.Parameters.Add(new SqlParameter("@TenLoaiSP", TenLoaiSP));
            cmd.Parameters.Add(new SqlParameter("@ThongTinLoai", ThongTinLoai));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaLoaiSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("LoaiSP_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int Check(String MaLoaiSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CheckMaLoaiSP_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
            int kq1 = (int)cmd.ExecuteScalar();
            con.Close();
            return kq1;

        }
        public DataTable TimKiem(String GiaTri)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TimKiem_MaLoaiSP", con);
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
