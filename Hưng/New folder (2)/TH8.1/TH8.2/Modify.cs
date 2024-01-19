using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TH8._2
{
    internal class Modify
    {
        public DataTable getData(string strSql)
        {
            try
            {
                SqlConnection sqlCon = Connect.getCon();
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, sqlCon);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                sqlCon.Close();
                return datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }  
        }

        public void updateData(string strSql)
        {
            try
            {
                SqlConnection sqlCon = Connect.getCon();
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);
                int n = sqlCmd.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Cập nhật không thành công");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
    }
}
