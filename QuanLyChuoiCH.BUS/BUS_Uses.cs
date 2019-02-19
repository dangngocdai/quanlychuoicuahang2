using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuoiCH.DAL;

namespace QuanLyChuoiCH.BUS
{
   public class BUS_Uses
    {
        Uses us = new Uses();
        public int checkDangNhap(string TK, string MK)
        {
            return us.DangNhap(TK, MK);

        }
    }
}
