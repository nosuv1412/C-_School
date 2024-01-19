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

namespace WindowsForms_18032022
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
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-14ATKF3\SQLEXPRESS01;Initial Catalog=QLKhachHang;Integrated Security=True");
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("select * from KhachHang", conn);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    string stt = dataGridView1.Rows.Count.ToString();
                    string ho_ten = reader["HoTen"].ToString();
                    string gioi_tinh = reader["GioiTinh"].ToString();
                    string loai_phong = reader["LoaiPhong"].ToString();
                    string so_phong = reader.GetInt32(4).ToString();
                    dataGridView1.Rows.Add(stt, ho_ten, gioi_tinh, loai_phong, so_phong);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
           
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-14ATKF3\SQLEXPRESS01;Initial Catalog=QLKhachHang;Integrated Security=True");
                conn.Open();
                string gioitinh = "";
                if (rdbNam.Checked == true)
                    gioitinh = "Nam";
                else if (rdbNu.Checked == true)
                    gioitinh = "Nữ";
                string stt = dataGridView1.Rows.Count.ToString();
                SqlCommand cmd = new SqlCommand($"insert into KhachHang values(N'{stt}',N'{txtKH.Text}',N'{gioitinh}',N'{cbLoaiphong.Text}','{txtSophong.Text}')", conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Thêm thành công!!");
                else
                    MessageBox.Show("Thêm thất bại");
                dataGridView1.Rows.Add(stt, txtKH.Text, gioitinh, cbLoaiphong.Text, txtSophong.Text);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-14ATKF3\SQLEXPRESS01;Initial Catalog=QLKhachHang;Integrated Security=True");
                conn.Open();
                string gioitinh = "";
                if (rdbNam.Checked == true)
                    gioitinh = "Nam";
                else if (rdbNu.Checked == true)
                    gioitinh = "Nữ";
                string stt = dataGridView1.Rows.Count.ToString();
                SqlCommand cmd = new SqlCommand($"update KhachHang set Hoten = N'{txtKH.Text}', GioiTinh = N'{gioitinh}', Loaiphong = N'{cbLoaiphong.Text}',Sophongthue = '{txtSophong.Text}' where MaKH = '{stt}' ", conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Sửa thành công!!");
                else
                    MessageBox.Show("Sửa thất bại");
                dataGridView1.Update();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-14ATKF3\SQLEXPRESS01;Initial Catalog=QLKhachHang;Integrated Security=True");
                conn.Open();
                string stt = dataGridView1.Rows.Count.ToString();
                SqlCommand cmd = new SqlCommand($"delete from KhachHang where MaKH = '{stt}'", conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Xoá thành công!!");
                else
                    MessageBox.Show("Xoá thất bại");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //string stt = row.Cells[0].Value.ToString();
                txtKH.Text = row.Cells[1].Value.ToString();
                cbLoaiphong.Text = row.Cells[3].Value.ToString();
                txtSophong.Text = row.Cells[4].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
            }
        }
    }
}
