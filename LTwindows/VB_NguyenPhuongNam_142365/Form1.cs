using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VB_NguyenPhuongNam_142365
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Chưa nhập dữ liệu!!");
            }
            else
            {
                errorProvider1.Clear();
                listBox.Items.Add(textBox1.Text.Trim());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
