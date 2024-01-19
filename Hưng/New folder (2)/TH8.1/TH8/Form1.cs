using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip() { IsBalloon = true };
            tip.SetToolTip(this, "Giá vé của hàng ghế này là: ");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = false;
        }

      

     

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
