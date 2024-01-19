using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thanh_tien = (so_luong.Value * int.Parse(txtDonGia.Text)).ToString();
            dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, cbTenHang.Text, so_luong.Value, txtDonGia.Text, thanh_tien);
            txtTenKH.Clear();
            cbTenHang.SelectedIndex=-1;
            so_luong.Value = 0;
            txtDonGia.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtTenKH.Focus();
        }
                
        private void màuĐỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button bt = contextMenuStrip1.SourceControl as Button;
            bt.BackColor = Color.Red;
        }

        private void màuXanhLáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.BackColor = cd.Color;
        }

        private void màuXanhLamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button bt = contextMenuStrip1.SourceControl as Button;
            bt.BackColor = Color.Blue;
        }

        private void màuĐenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button bt = contextMenuStrip1.SourceControl as Button;
            bt.BackColor = Color.Black;
        }
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    cbTenHang.Text = row.Cells[1].Value.ToString();
                    so_luong.Text = row.Cells[2].Value.ToString();
                    txtDonGia.Text = row.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenHang.SelectedIndex == 0)
                txtDonGia.Text = "10000";
            if (cbTenHang.SelectedIndex == 1)
                txtDonGia.Text = "15000";
            if (cbTenHang.SelectedIndex == 2)
                txtDonGia.Text = "2500";
        }
    }
}
