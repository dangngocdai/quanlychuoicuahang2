using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyChuoiCH.DAL
{
    public partial class DAL_NhaCC:DBConnect
    {
        public DataTable GetData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhaCC_Lay", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaNCC, String TenNCC, String SDTNCC, String DiaChi)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhaCC_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.Parameters.Add(new SqlParameter("@TenNCC", TenNCC));
            cmd.Parameters.Add(new SqlParameter("@SDTNCC", SDTNCC));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateData(String MaNCC, String TenNCC, String SDTNCC, String DiaChi)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhaCC_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.Parameters.Add(new SqlParameter("@TenNCC", TenNCC));
            cmd.Parameters.Add(new SqlParameter("@SDTNCC", SDTNCC));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaNCC)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("NhaCC_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int Check(String MaNCC)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CheckMaNhaCC_SanPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            int kq1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("CheckMaNhaCC_HDNhapKho", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            int kq2 = (int)cmd.ExecuteScalar();
            con.Close();
            return kq1 + kq2;

        }
        public DataTable TimKiem(String GiaTri)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TimKiem_NhaCC", con);
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
