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

namespace TH8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'donhangDataSet.DONHANG' table. You can move, or remove it, as needed.
            this.dONHANGTableAdapter.Fill(this.donhangDataSet.DONHANG);
            txtDonGia.Enabled = false;
            txtTongTien.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string thanh_tien = (so_luong.Value * int.Parse(txtDonGia.Text)).ToString();
            dataGridView1.Rows.Add(dataGridView1.Rows.Count, cbTenHang.Text, so_luong.Value, txtDonGia.Text, thanh_tien);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum = sum + int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }

                txtTongTien.Text = sum.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtTenKH.Focus();
        }

        private void màuĐỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button bt = contextMenuStrip1.SourceControl as Button;
            bt.BackColor = Color.Red;
        }

        private void màuXanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button bt = contextMenuStrip1.SourceControl as Button;
            bt.BackColor = Color.Green;
        }

        private void màuVàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button bt = contextMenuStrip1.SourceControl as Button;
            bt.BackColor = Color.Yellow;
        }
    }
}
