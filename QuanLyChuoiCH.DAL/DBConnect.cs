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
        protected SqlConnection con = new SqlConnection(@"Data Source = TIENTHANH\SQLEXPRESS ;Initial Catalog=QuanLyChuoiCuaHang2;Integrated Security=True");//(@"Data Source = DESKTOP-CN03OE1\SQLEXPRESS ;Initial Catalog=QuanLyChuoiCuaHang2;Integrated Security=True;User ID=sa; Password=dai1251998");//tạo biến kết nỗi csdl

    }
}
