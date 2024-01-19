using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4_Bai1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtYourName_Leave(object sd, EventArgs e)
        {
            this.errorProvider1.SetError(txtYourName, "Chưa nhập tên!!!");
            if(((Control)sd).Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtYourName, "Chưa nhập tên!!!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        

        private void btnShow_Click(object sender, EventArgs e)
        {
                string name = "Tôi tên là: " + txtYourName.Text + "\nNăm sinh: " + txtYear.Text;
                MessageBox.Show(name);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYear.Clear();
            txtYourName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không?","Exit" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if( result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txtYear, "Chưa nhập năm sinh!!!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
