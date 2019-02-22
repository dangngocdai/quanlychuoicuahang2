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
   public partial class BUS_NhaCC
    {
        DAL_NhaCC NCC = new DAL_NhaCC();
        public DataTable GetData()
        {
            return NCC.GetData();
        }
    }
}
