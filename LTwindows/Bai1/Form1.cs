using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool nt(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)              
                if (n % i == 0)
                    return false;
            return true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(input.Text);
            string s = "";
            for (int i = 2; i < n; i++)
                if(nt(i) == true)
                    s = s + i.ToString() + " ";
            lb1.Text = lb1.Text + " " + s;

            s = " ";
            for (int i = 2; i < n; i++)
                if (cp(i) == true)
                    s = s + i.ToString() + " ";
            lb2.Text = lb2.Text + s;

            s = " ";
            for (int i = 2; i < n; i++)
                if (uoc(i) == i)
                    s = s + i.ToString() + " ";
            lb3.Text = lb3.Text + s;
        }
    }
}
