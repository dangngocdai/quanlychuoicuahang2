using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DAL_CTHDBan : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDBan_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaCTHDBan, String MaHDBan, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDBan_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCTHDBan", MaCTHDBan));
            cmd.Parameters.Add(new SqlParameter("@MaHDBan", MaHDBan));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaCTHDBan, String MaHDBan, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDBan_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCTHDBan", MaCTHDBan));
            cmd.Parameters.Add(new SqlParameter("@MaHDBan", MaHDBan));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaCTHDBan)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CTHDBan_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCTHDBan", MaCTHDBan));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
