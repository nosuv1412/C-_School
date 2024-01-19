using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pheptinh()
        {
            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    return item.Text;
                }
            }
            return null;
        }

        public void KetQua()
        {
            double so1 = double.Parse(txt1.Text);
            double so2 = double.Parse(txt2.Text);
            double ketqua = 0;
            switch (pheptinh())
            {
                case "Cộng":
                    ketqua = so1 + so2;
                    break;
                case "Trừ":
                    ketqua = so1 - so2;
                    break;
                case "Nhân":
                    ketqua = so1 * so2;
                    break;
                case "Chia":
                    if (so2 == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0. Vui lòng thử lại!");
                    }
                    else
                    {
                        ketqua = so1 / so2;
                    }
                    break;
            }
            txtKetQua.Text = ketqua.ToString();
        }
        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
            KetQua();
        }

    }
}
