using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyChuoiCH.DAL
{
    public class DAL_SanPham : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaSP, String TenSP, String MaLoaiSP, String MaNhomSP, String MaNCC, String ThongTinSP , String GiaBan , String BaoHanh)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@TenSP", TenSP));
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
            cmd.Parameters.Add(new SqlParameter("@MaNhomSP", MaNhomSP));
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.Parameters.Add(new SqlParameter("@ThongTinSP", ThongTinSP));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", GiaBan));
            cmd.Parameters.Add(new SqlParameter("@BaoHanh", BaoHanh));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaSP, String TenSP, String MaLoaiSP, String MaNhomSP, String MaNCC, String ThongTinSP, String GiaBan, String BaoHanh)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@TenSP", TenSP));
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
            cmd.Parameters.Add(new SqlParameter("@MaNhomSP", MaNhomSP));
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.Parameters.Add(new SqlParameter("@ThongTinSP", ThongTinSP));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", GiaBan));
            cmd.Parameters.Add(new SqlParameter("@BaoHanh", BaoHanh));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int Check_MaSP(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CheckMaSP_CTHDBan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            int kq1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaSP_CTHDNhapKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            int kq2 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaSP_CTHDXuatKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            int kq3 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaSP_SPTonCH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            int kq4 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaSP_SPTonKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            int kq5 = (int)cmd.ExecuteScalar();
            con.Close();
            return kq1 + kq2 + kq3 + kq4 + kq5;
        }

    }
}
