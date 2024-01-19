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

namespace QLKH
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-14ATKF3\SQLEXPRESS01;Initial Catalog=QLKhachHang;Integrated Security=True");
            sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand("select * from DATHANG", sqlCon);

            // thực thi câu lệnh
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                string stt = dataGridView1.Rows.Count.ToString();
                string hoten = reader["Hoten"].ToString();
                string gioitinh = reader["Gioitinh"].ToString();
                string loaiphong = reader["Loaiphong"].ToString();
                string sophongthue = reader["Sophongthue"].ToString();
                dataGridView1.Rows.Add(stt, hoten, gioitinh, loaiphong, sophongthue);

            }
            reader.Close();
            sqlCon.Close();
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells[1].Value.ToString();
                    comboBox1.Text = row.Cells[3].Value.ToString();
                    textBox2.Text = row.Cells[4].Value.ToString();
                    if (row.Cells[2].ToString() == "Nam")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
