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

namespace Quanlysinhvien_TH07
{
    public partial class XemDiem : Form
    {
        public XemDiem()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = global::Quanlysinhvien_TH07.Properties.Settings.Default.QuanLySinhVienConnectionString;
            string str;
            str = string.Format("select TenMH, Diem from KetQua, Mon where KetQua.MaMH = Mon.MaMH and  MaSo = {0}",comboBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(str,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);    
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLySinhVienDataSet);

        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.quanLySinhVienDataSet.Khoa);
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanLySinhVienDataSet.SinhVien);

        }
    }
}
