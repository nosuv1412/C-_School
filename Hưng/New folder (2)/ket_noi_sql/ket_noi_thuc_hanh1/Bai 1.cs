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

namespace ket_noi_thuc_hanh1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form1_Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Lock();
                btThem.Enabled = true;
                SqlConnection sqlCon = new SqlConnection("Data Source=HUNG;Initial Catalog=sach;Integrated Security=True");
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from SACH", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string ma_sach = reader.GetString(0);
                        string tieu_de = reader.GetString(1);
                        string gia = reader.GetInt32(2).ToString();
                        string so_luong = reader.GetInt32(3).ToString();
                        ListViewItem lsv = new ListViewItem(ma_sach);
                        lsv.SubItems.Add(tieu_de);
                        lsv.SubItems.Add(gia);
                        lsv.SubItems.Add(so_luong);
                        listView1.Items.Add(lsv);
                    }
                    reader.Close();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Lock()
        {
            txtMaSach.Enabled = false;
            txtTieuDe.Enabled = false;
            txtGia.Enabled = false;
            txtSoLuong.Enabled = false;
            btThem.Enabled = false;
            btLuu.Enabled = false;
            btBoqua.Enabled = false;
            btXoa.Enabled = false;
        }

        public void unlock()
        {
            txtMaSach.Enabled = true;
            txtTieuDe.Enabled = true;
            txtGia.Enabled = true;
            txtSoLuong.Enabled = true;
            btThem.Enabled = true;
            btLuu.Enabled = true;
            btBoqua.Enabled = true;
            btXoa.Enabled = true;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            unlock();
            btThem.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=HUNG;Initial Catalog=sach;Integrated Security=True");
                sqlCon.Open();
                string ma_sach = txtMaSach.Text.ToString();
                string tieu_de = txtTieuDe.Text.ToString();
                string gia = txtGia.Text.ToString();
                string so_luong = txtSoLuong.Text.ToString();
                string sqlThem = $"insert into SACH values ('{ ma_sach}',N'{tieu_de}','{gia}','{so_luong}')";
                SqlCommand sqlCmd = new SqlCommand(sqlThem, sqlCon);
                ListViewItem lsv = new ListViewItem(ma_sach);
                lsv.SubItems.Add(tieu_de);
                lsv.SubItems.Add(gia);
                lsv.SubItems.Add(so_luong);
                listView1.Items.Add(lsv);
                int n = sqlCmd.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            Lock();
            btThem.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            SqlConnection sqlCon = new SqlConnection("Data Source=HUNG;Initial Catalog=sach;Integrated Security=True");
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand($"delete from SACH where ma_sach ='{txtMaSach.Text}'", sqlCon);
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
            sqlCon.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                ListViewItem lsv = listView1.SelectedItems[0];
                string ma_sach = lsv.SubItems[0].Text;
                string tieu_de = lsv.SubItems[1].Text;
                string gia = lsv.SubItems[2].Text;
                string so_luong = lsv.SubItems[3].Text;

                txtMaSach.Text = ma_sach;
                txtTieuDe.Text = tieu_de;
                txtGia.Text = gia;
                txtSoLuong.Text = so_luong;
            }    
        }
    }
    
}

