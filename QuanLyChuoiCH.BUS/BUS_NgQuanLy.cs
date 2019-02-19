using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{  
    public class BUS_NgQuanLy
    {
        DAL_NgQuanLy QL = new DAL_NgQuanLy();
        public DataTable getData()
        {
            return QL.GetData();
        }

    }
}
