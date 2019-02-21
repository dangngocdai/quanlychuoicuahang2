using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.DAL
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-DLMLEOH\SQLEXPRESS ;Initial Catalog=QuanLyChuoiCuaHang2;Integrated Security=True");//tạo biến kết nỗi csdl

    }
}
