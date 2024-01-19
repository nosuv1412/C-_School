using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void them_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(msv.Text, name.Text, birth.Text,check(), que.Text, lop.Text, khoa.Text);
        }

        public string check()
        {
            if (nam.Checked == true)
                return "Nam";
            else
                return "Nữ";
        }
        private void nam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            }
            catch (Exception)
            {

                MessageBox.Show("Dòng hiện tại đang NULL","Cảnh báo");
            }
        }
    }
}
