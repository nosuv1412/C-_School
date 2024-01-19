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

namespace TH7_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-14ATKF3\SQLEXPRESS01;Initial Catalog=thongtinsach;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from sach", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string masach = reader["Masach"].ToString();
                    string tieude = reader["Tieude"].ToString();
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
