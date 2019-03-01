﻿using System;
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
        public void insertData(String MaSP, String TenSP, String MaLoaiSP, String MaNCC, String ThongTinSP , String GiaBan , String BaoHanh)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_Them", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@TenSP", TenSP));
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
           
            cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            cmd.Parameters.Add(new SqlParameter("@ThongTinSP", ThongTinSP));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", GiaBan));
            cmd.Parameters.Add(new SqlParameter("@BaoHanh", BaoHanh));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(String MaSP, String TenSP, String MaLoaiSP, String MaNCC, String ThongTinSP, String GiaBan, String BaoHanh)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_Sua", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            cmd.Parameters.Add(new SqlParameter("@TenSP", TenSP));
            cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", MaLoaiSP));
            
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
        public DataTable TimKiem(String GiaTri)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TimKiem_SanPham", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@GiaTri", GiaTri));
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);

            con.Close();
            return tb;
        }
        public string TenSP(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("selectTenSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            String kq = (String)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public string NhaCC(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("selectNhaCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            String kq = (String)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public string ThongTin(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("selectThongTinSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            String kq = (String)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public string GiaBan(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("selectGiaSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            String kq = (String)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public string BaoHanh(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("selectBaoHanhSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            String kq = (String)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
        public string LoaiSP(String MaSP)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("selectLoaiSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            String kq = (String)cmd.ExecuteScalar();
            con.Close();
            return kq;
        }
    }
}
