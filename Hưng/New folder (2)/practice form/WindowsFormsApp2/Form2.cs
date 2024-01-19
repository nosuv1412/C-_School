using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBox3.Text = "";
            giai.Enabled = true;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Giải phương trình bậc nhất", "Bạn có muốn thoát không?", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
                Close();
        }
        private void check(string tmp)
        {
            string s = tmp;
            foreach (char i in s)
            {
                if (!char.IsDigit(i))
                {
                    MessageBox.Show(s+" không phải là số!");
                    break;
                }

            }
        }
        private void giai_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxA, "");
            if(textBoxA.Text.Trim()=="")
            {
                errorProvider1.SetError(textBoxA, "Bạn chưa nhập giá trị A!");
            }

            errorProvider1.SetError(textBoxB, "");
            if(textBoxB.Text.Trim()=="")
            {
                errorProvider1.SetError(textBoxB, "Bạn chưa nhập giá trị B!");
            }
            check(textBoxA.Text);
            check(textBoxB.Text);
            textBox3.Text = (-int.Parse(textBoxB.Text) / int.Parse(textBoxA.Text)).ToString();
            giai.Enabled = false;
        }
    }
}
