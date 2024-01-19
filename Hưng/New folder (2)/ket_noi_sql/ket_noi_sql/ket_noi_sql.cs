using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ket_noi_sql
{
    public partial class ket_noi_sql : Form
    {
        public ket_noi_sql()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        private void btDataReader_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=HUNG;Initial Catalog=ket_noi_form;Integrated Security=True");
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from LoaiPhong", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string loai_phong = reader["ten_loai_phong"].ToString();
                        string mo_ta = reader["mo_ta"].ToString();
                        dataGridView1.Rows.Add(id, loai_phong, mo_ta);
                    }
                }
                reader.Close();
                sqlCon.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAdapter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=HUNG;Initial Catalog=ket_noi_form;Integrated Security=True");
                sqlCon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from LoaiPhong",sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataTable;
                sqlCon.Close();     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=HUNG;Initial Catalog=ket_noi_form;Integrated Security=True");
                sqlCon.Open();
                string id = txtID.Text.ToString();
                string ten_loai_phong = txtTen.Text.ToString();
                string mo_ta = txtMoTa.Text.ToString();
                string sqlThem = $"insert into LoaiPhong values('{id}', N'{ten_loai_phong}', N'{mo_ta}')";
                SqlCommand sqlCmd = new SqlCommand(sqlThem, sqlCon);
                int n = sqlCmd.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
