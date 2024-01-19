using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        txtNghiem.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        txtNghiem.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    double x = -b / a;
                    txtNghiem.Text = x.ToString();
                    btnXoa.Enabled = true;
                    btnGiai.Enabled = false;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();
            btnXoa.Enabled = false;
            txtA.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }


        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                errorProvider1.SetError(txtA, "Hãy nhập số A!!!");
                btnGiai.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                if (txtA.Text != "")
                {
                    btnGiai.Enabled = true;
                }
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtB.Text == "")
            {
                errorProvider1.SetError(txtA, "Hãy nhập số A!!!");
                btnGiai.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                if (txtB.Text != "")
                {
                    btnGiai.Enabled = true;
                }
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtA, "");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txtA, "Hãy nhập số A!!!");
                btnGiai.Enabled = false;
            }
            else
            {
                if(txtB.Text!="" || txtA.Text!="")
                    btnGiai.Enabled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtB, "");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txtB, "Hãy nhập số B!!!");
                btnGiai.Enabled = false;
            }
              else
                {
                    if (txtB.Text != "" || txtA.Text != "")
                        btnGiai.Enabled = true;
                }
            }
    }
}
