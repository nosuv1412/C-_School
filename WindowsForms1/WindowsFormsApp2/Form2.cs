using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

//Chụp hình	      150 000 VNĐ
//Lấy cao		      100 000 VNĐ
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ten_kh_TextChanged(object sender, EventArgs e)
        {
            string s = ten_kh.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tinh_tien_Click(object sender, EventArgs e)
        {
            long sum = 0;
            foreach (int x in bang_gia.CheckedIndices)
            {
                if (x == 0 || x == 3)
                    sum += 100000;
                if (x == 1)
                    sum += 1200000;
                if (x == 2)
                    sum += 150000;
            }
            int n = int.Parse(han_rang.Text);
            sum += n * 90000;
            tong_tien.Text = sum.ToString();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult=MessageBox.Show("Ban co muon thoat khong", "Tinh toan gia tien",MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
                Close();
        }
    }
}
