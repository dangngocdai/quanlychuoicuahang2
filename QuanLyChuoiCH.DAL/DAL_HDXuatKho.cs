using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DAL_HDXuatKho:DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDXuatKho_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaHDXuatKho, String MaKho, String MaCH, String NgayXuat, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDXuatKho_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDXuatKho", MaHDXuatKho));
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@NgayXuat", NgayXuat));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));
           
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaHDXuatKho, String MaKho, String MaCH, String NgayXuat, String MaNgQuanLy)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDXuatKho_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDXuatKho", MaHDXuatKho));
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@NgayXuat", NgayXuat));
            cmd.Parameters.Add(new SqlParameter("@MaNgQuanLy", MaNgQuanLy));

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaHDXuatKho)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("HDXuatKho_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHDXuatKho", MaHDXuatKho));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
