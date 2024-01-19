using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace ket_noi_sql
{
    public class connect
    {
        public static string strCon = @"Data Source=HUNG;Initial Catalog=ket_noi_form;Integrated Security=True";


        public static SqlConnection getCon()
        {
            return new SqlConnection(strCon);
        }

       
    }
}
