using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check(nhan);
            kq.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
            chia.Checked = false;
        }
        private void check(RadioButton rdbutton)
        {
            errorProvider1.SetError(textBox1, "");
            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Bạn chưa nhập số 1!");
                rdbutton.Checked = false;
            }
            errorProvider1.SetError(textBox2, "");
            if (textBox2.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox2, "Bạn chưa nhập số 2!");
                rdbutton.Checked = false;
            }

            double test;
            bool check=double.TryParse(textBox1.Text, out test);
            if (check == false)
                MessageBox.Show("Đây không phải là số hợp lệ!");
            check= double.TryParse(textBox2.Text, out test);
            if (check == false)
                MessageBox.Show("Đây không phải là số hợp lệ!");
        }

        private void cong_CheckedChanged(object sender, EventArgs e)
        {
            check(cong);
            kq.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
            cong.Checked = false;
        }

        private void tru_CheckedChanged(object sender, EventArgs e)
        {
            check(tru);
            kq.Text = (double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString();
            tru.Checked = false;
        }

        private void chia_CheckedChanged(object sender, EventArgs e)
        {
            check(chia);
            kq.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();
            chia.Checked = false;
        }
    }
}
