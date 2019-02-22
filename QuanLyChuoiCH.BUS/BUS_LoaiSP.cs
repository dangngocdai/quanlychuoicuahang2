using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuoiCH.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChuoiCH.BUS
{
    public partial class BUS_LoaiSP
    {
        DAL_LoaiSP LSP = new DAL_LoaiSP();
       public DataTable GetData()
        {
            return LSP.GetData();
        }
    }
}
