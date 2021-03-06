﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyChuoiCH.DAL
{
    public class DAL_SPTonCH : DBConnect
    {
        public DataTable GetData(String MaCH)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_LayTheoCH", con);//thực hiện các câu lệnh truy vẫn. nhưng đéo có truy vẫn mà là store procedure
            cmd.CommandType = CommandType.StoredProcedure;//chú thích cho hiểu là đang dùng storedprocedure
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public void insertData(String MaKho, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaKho, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKho", MaKho));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(String MaKho)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_Xoa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaKho));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int CheckMaSP(String MaSP, String MaCH)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_CheckSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            int kq = (int)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public void ThemSP(String MaCH, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_ThemSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void BoSP(String MaCH, String MaSP, String SoLuong)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_BoSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int CheckSoLuong(String MaCH, String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPTonCH_CheckSoLuong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@MaCH", MaCH));
            int kq = (int)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
    }
}
