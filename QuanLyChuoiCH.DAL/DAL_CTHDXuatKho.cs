using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
   public class DAL_CTHDXuatKho : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDXuatKho_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaHDXuatKho, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDXuatKho_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("@MaCTHDNhapKho", MaCTHDNhapKho));
            cmd.Parameters.Add(new SqlParameter("@MaHDXuatKho", MaHDXuatKho));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            //cmd.Parameters.Add(new SqlParameter("@GiaNhap", GiaNhap));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update( String MaHDXuatKho, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDXuatKho_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add(new SqlParameter("@MaCTHDNhapKho", MaCTHDNhapKho));
            cmd.Parameters.Add(new SqlParameter("@MaHDXuatKho", MaHDXuatKho));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            //cmd.Parameters.Add(new SqlParameter("@GiaNhap", GiaNhap));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaCTHDXuatKho)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDXuatKho_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCTHDXuatKho", MaCTHDXuatKho));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
