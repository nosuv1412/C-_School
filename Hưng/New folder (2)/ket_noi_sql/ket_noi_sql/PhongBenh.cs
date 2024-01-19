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
    public partial class PhongBenh : Form
    {
        SqlConnection sqlCon = null;
        Modify modify = new Modify();

        public PhongBenh()
        {
            InitializeComponent();
            try
            {
                DataTable dataTable = modify.getData("select * from LoaiPhong");
                cbLoaiPhong.DataSource = dataTable;
                cbLoaiPhong.DisplayMember = "ten_loai_phong";
                cbLoaiPhong.ValueMember = "id"; 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void hienThiDL()
        {
            dataGridView1.DataSource=modify.getData("select * from PhongBenh");
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PhongBenh_Load(object sender, EventArgs e)
        {
            hienThiDL();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            modify.updateData($"insert into PhongBenh values ('{txtId.Text}','{txtTenPhong.Text}',{int.Parse(txtGiuongToiDa.Text)},{int.Parse(txtGiuongHienTai.Text)},N'{cbLoaiPhong.Text}')");
            hienThiDL();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            modify.updateData($"delete from PhongBenh where id='{txtId.Text}'");
            hienThiDL();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng vừa click
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //Đưa dữ liệu vào textbox
                txtId.Text = row.Cells[0].Value.ToString();
                txtTenPhong.Text = row.Cells[1].Value.ToString();
                txtGiuongToiDa.Text = row.Cells[2].Value.ToString();
                txtGiuongHienTai.Text = row.Cells[3].Value.ToString();
                cbLoaiPhong.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
