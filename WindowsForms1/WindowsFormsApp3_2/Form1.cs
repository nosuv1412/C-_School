using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text += "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            output.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text += "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text += "-";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            output.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text += "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            output.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            output.Text += "/";
        }

        public void check(ref double n, char c,string tmp)
        {
            switch (c)
            {
                case '+': n = n + double.Parse(tmp);
                    break;
                case '-': n = n - double.Parse(tmp);
                    break;
                case '*': n = n * double.Parse(tmp);
                    break;
                case '/': n = n / double.Parse(tmp);
                    break;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            string tmp = "",s=output.Text;
            double n=0;
            foreach(char c in s)
            {
                if (char.IsDigit(c))
                    tmp += c;
                else
                {
                    check(ref n, c, tmp);
                    tmp = "";
                }    
            }
            kqua.Text = n.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            output.Text += "7";
        }
    }
}
