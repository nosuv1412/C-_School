using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH8_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlybanhangDataSet.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this.quanlybanhangDataSet.DonHang);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ThanhTien = (int.Parse(txtDonGia.Text) * soluong.Value).ToString();
            dataGridView1.Rows.Add(dataGridView1.Rows.Count+1, cbTenHang.Text, soluong.Value, txtDonGia.Text, ThanhTien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int n = dataGridView1.Rows.Count;
            for(int i = 0; i < n; i++)
            {
                sum += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            } 
            txtTongTien.Text = sum.ToString();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtTenKhach.Focus();    
        }
    }
}
