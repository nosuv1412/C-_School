using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TH8_bai2
{
    internal class connect
    {
        public static string strSql = @"Data Source = DESKTOP - 14ATKF3\SQLEXPRESS01;Initial Catalog = qlsinhvien_TH8; Integrated Security = True");

        public static SqlConnection getCon()
        {
            return new SqlConnection(strSql);
        }
    }
}
