using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public bool cp(int n)
        {
            if (Math.Sqrt(n) == Math.Floor(Math.Sqrt(n)))
                return true;
            return false;
        }

        public int uoc(int n)
        {
            int sum = 0;
            for (int i = 1; i < n / 2 + 1; i++)
                if (n % i == 0)
                    sum += i;
            return sum;
            
                 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(input.Text);
            string s="";
            for (int i = 0; i < n; i++)
                s=s+i.ToString()+" ";
            lb1.Text = lb1.Text+ " " + s;

            s = " ";
            for (int i = 2; i < n; i++)
                if (cp(i)==true)
                    s = s + i.ToString() + " ";
            lb2.Text = lb2.Text + s;

            s = " ";
            for (int i = 2; i < n; i++)
                if (uoc(i) == i)
                    s = s + i.ToString() + " ";
            lb3.Text = lb3.Text + s;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
