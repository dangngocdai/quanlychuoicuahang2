using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DAL_CuaHang:DBConnect
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
    }
}
