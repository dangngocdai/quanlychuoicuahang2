using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyChuoiCH.DAL
{
    public partial class DAL_NhomSP : DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhomSP_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaNhomSP, String TenNhomSP, String ThongTinNhom)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhomSP_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhomSP", MaNhomSP));
            cmd.Parameters.Add(new SqlParameter("@TenNhomSP", TenNhomSP));
            cmd.Parameters.Add(new SqlParameter("@ThongTinNhom", ThongTinNhom));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateData(String MaNhomSP, String TenNhomSP, String ThongTinNhom)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhomSP_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhomSP", MaNhomSP));
            cmd.Parameters.Add(new SqlParameter("@TenNhomSP", TenNhomSP));
            cmd.Parameters.Add(new SqlParameter("@ThongTinNhom", ThongTinNhom));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaNhomSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhomSP_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhomSP", MaNhomSP));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int Check(String MaNhomSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CheckMaNhomSP_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhomSP", MaNhomSP));
            int kq1 = (int)cmd.ExecuteScalar();
            con.Close();
            return kq1;

        }
        public DataTable TimKiem(String GiaTri)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TimKiemMaNhomSP", con);
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
