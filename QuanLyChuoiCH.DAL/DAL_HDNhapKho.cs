using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyChuoiCH.DAL
{
   public class DAL_HDNhapKho : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDNhapKho_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaHDNhapKho, String MaKho, String NgayNhap, String MaNCC, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDNhapKho_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDNhapKho", MaHDNhapKho));
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@NgayNhap", NgayNhap));
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaHDNhapKho, String MaKho, String NgayNhap, String MaNCC, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDNhapKho_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDNhapKho", MaHDNhapKho));
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@NgayNhap", NgayNhap));
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaHDNhapKho)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDNhapKho_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDNhapKho", MaHDNhapKho));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
