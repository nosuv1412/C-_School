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
    class Modify
    {
        public DataTable getData(string strSql)
        {
            try
            {
                SqlConnection sqlCon =connect.getCon();
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, sqlCon);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                sqlCon.Close();
                return dataTable;

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
                SqlConnection sqlCon = connect.getCon();
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand(strSql, sqlCon);
                int n = sqlCmd.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Cập nhật thất bại");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
