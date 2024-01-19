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

namespace TH8._2
{
    public partial class Form1 : Form
    {
        Modify modify = new Modify();
        public Form1()
        {
            InitializeComponent();
        }

        public void hienThiDS()
        {
            dataGridView1.DataSource = modify.getData("select * from SINHVIEN");
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienThiDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gioi_tinh;
            if (rbNam.Checked == true)
                gioi_tinh = "Nam";
            else
                gioi_tinh = "Nữ";
            string strSql = $"insert into SINHVIEN values ('{txtMaSV.Text}',N'{txtHoTen.Text}','{dateTimePicker1.Value}',N'{gioi_tinh}',N'{cbNoiSinh.Text}')";
            modify.updateData(strSql);
            hienThiDS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gioi_tinh;
            if (rbNam.Checked == true)
                gioi_tinh = "Nam";
            else
                gioi_tinh = "Nữ";
            string strSql = $"update SINHVIEN set ten_sv=N'{txtHoTen.Text}',ngay_sinh='{dateTimePicker1.Value}',dia_chi=N'{cbNoiSinh.Text}',gioi_tinh=N'{gioi_tinh}' where ma_sv ={txtMaSV.Text}";
            modify.updateData(strSql);
            hienThiDS();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtMaSV.Text = row.Cells[0].Value.ToString();
                    txtHoTen.Text = row.Cells[1].Value.ToString();
                    dateTimePicker1.Text=row.Cells[2].Value.ToString();
                    cbNoiSinh.Text = row.Cells[4].Value.ToString();
                    if (row.Cells[3].ToString() == "Nam")
                        rbNam.Checked = true;
                    else
                        rbNu.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSql = $"delete from SINHVIEN where ma_sv='{txtMaSV.Text}'";
            modify.updateData(strSql);
            hienThiDS();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string gioi_tinh;
            if (rbNam.Checked == true)
                gioi_tinh = "Nam";
            else
                gioi_tinh = "Nữ";
            string strSql = $"select * from SINHVIEN where ma_sv like '{txtMaSV.Text}' or dia_chi like N'{cbNoiSinh.Text}' or gioi_tinh like N'{gioi_tinh}'";
            dataGridView1.DataSource= modify.getData(strSql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
