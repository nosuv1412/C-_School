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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
               this.BackColor = colorDialog1.Color;
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("C:\\Users\\APC\\OneDrive\\Hình ảnh\\Ảnh chụp màn hình");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Họ và tên học viên", "Bạn có muốn thoát không", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
                Close();
        }
    }
}
