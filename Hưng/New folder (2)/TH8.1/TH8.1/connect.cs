using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TH8._1
{
    class connect
    {
        public static string strCon = "Data Source=HUNG;Initial Catalog=qli_sv;Integrated Security=True";

        public static SqlConnection getCon()
        {
            return new SqlConnection(strCon);
        }
    }
}
