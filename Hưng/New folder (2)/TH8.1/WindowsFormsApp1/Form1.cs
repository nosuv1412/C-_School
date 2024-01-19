using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        long sum = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.BackColor != Color.FromArgb(192, 255, 255))
            {
                button.BackColor = Color.FromArgb(192, 255, 255);
                sum -= 25000;
            }
            else
            {
                button.BackColor = Color.Green;
                sum += 25000;
            }
            lbThanhTien.Text = "Thành tiền: ";
            lbThanhTien.Text = lbThanhTien.Text + sum.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor != Color.FromArgb(192, 255, 192))
            {
                button.BackColor = Color.FromArgb(192, 255, 192);
                sum -= 30000;
            }
            else
            {
                button.BackColor = Color.Green;
                sum += 30000;
            }
            lbThanhTien.Text = "Thành tiền: ";
            lbThanhTien.Text = lbThanhTien.Text + sum.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor != Color.FromArgb(255, 255, 192))
            {
                button.BackColor = Color.FromArgb(255, 255, 192);
                sum -= 35000;
            }
            else
            {
                button.BackColor = Color.Green;
                sum += 35000;
            }
            lbThanhTien.Text = "Thành tiền: ";
            lbThanhTien.Text = lbThanhTien.Text + sum.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor != Color.FromArgb(255, 192, 255))
            {
                button.BackColor = Color.FromArgb(255, 192, 255);
                sum -= 40000;
            }
            else
            {
                button.BackColor = Color.Green;
                sum += 40000;
            }
            lbThanhTien.Text = "Thành tiền: ";
            lbThanhTien.Text = lbThanhTien.Text + sum.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor != Color.FromArgb(255, 192, 192))
            {
                button.BackColor = Color.FromArgb(255, 192, 192);
                sum -= 50000;
            }
            else
            {
                button.BackColor = Color.Green;
                sum += 50000;
            }
            lbThanhTien.Text = "Thành tiền: ";
            lbThanhTien.Text = lbThanhTien.Text + sum.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor != Color.FromArgb(255, 224, 192))
            {
                button.BackColor = Color.FromArgb(255, 224, 192);
                sum -= 45000;
            }
            else
            {
                button.BackColor = Color.Green;
                sum += 45000;
            }
            lbThanhTien.Text = "Thành tiền: ";
            lbThanhTien.Text = lbThanhTien.Text + sum.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbTenPhim, "");
            if (cbTenPhim.Text == "")
                errorProvider1.SetError(cbTenPhim, "Bạn chưa chọn bộ phim!");
            else
            {
                lbThanhTien.Text = "Thành tiền: ";
                DialogResult = MessageBox.Show("Bạn có muốn chọn các ghế này không?", "Chương trình bán vé xem phim", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(lbThanhTien.Text = lbThanhTien.Text + sum.ToString());
                    foreach (var button in this.Controls.OfType<Button>())
                        if (button.BackColor == Color.Green)
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                }
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenPhim.Text = "Mời bạn chọn ghế trong phòng chiếu phim: "+cbTenPhim.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
