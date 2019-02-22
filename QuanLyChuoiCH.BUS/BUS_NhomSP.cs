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
    public partial class BUS_NhomSP
    {
        DAL_NhomSP NSP = new DAL_NhomSP();
        public DataTable GetData()
        {
            return NSP.GetData();
        }
    }
}
