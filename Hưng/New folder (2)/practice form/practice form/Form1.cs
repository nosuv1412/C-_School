using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtYourName.Text = "";
            txtYear.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult=MessageBox.Show("My name project", "Bạn có muốn thoát chương trình không", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
                Close();
        }

        private void txtYourName_TextChanged(object sender, CancelEventArgs e)
        {
            
        }

        private void check()
        {
            string s = txtYear.Text;
            foreach(char i in s)
            {
                if (!char.IsDigit(i))
                {
                    MessageBox.Show("Đây không phải là năm sinh!");
                    break;
                }    
                    
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // xoa loi cu
            errorProvider1.SetError(txtYourName, "");
            // set loi
            if (txtYourName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtYourName, "Hãy nhập tên của bạn!");
            }

            errorProvider1.SetError(txtYear, "");
            if(txtYear.Text.Trim()=="")
            {
                errorProvider1.SetError(txtYear, "Hãy nhập năm sinh của bạn!");
            }
            check();
            int tuoi = 2022-int.Parse(txtYear.Text);
            MessageBox.Show("Họ và tên: "+txtYourName.Text+"\nTuổi: "+tuoi.ToString());
            
        }

        private void txtYear_TextChanged(object sender, CancelEventArgs e)
        {

            }
        }
    }

