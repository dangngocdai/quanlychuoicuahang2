using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyChuoiCH.DAL
{
    public class Uses: DBConnect 
    {   
        public int DangNhap (String TK, String MK)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Uses_Xacnhandangnhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TaiKhoan", TK));
            cmd.Parameters.Add(new SqlParameter("@MatKhau", MK));
            int kq = (int)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
    }
}
