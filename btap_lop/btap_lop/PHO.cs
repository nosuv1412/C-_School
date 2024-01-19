using System;
using System.Collections.Generic;
using System.Text;

namespace btap_lop
{
    class PHO
    {
        private double thit, banh_pho, hanh;

        public PHO()
        {
        }

        public PHO(double thit, double banh_pho, double hanh)
        {
            this.thit = thit;
            this.banh_pho = banh_pho;
            this.hanh = hanh;
        }

        public double tinh_tien()
        {
            return this.thit * 15000 + this.banh_pho * 10000 + this.hanh * 2000;
        }

        public void display()
        {
            Console.WriteLine( this.thit + "\t" + this.banh_pho + "\t\t" + this.hanh+"\t"+tinh_tien());
        }

        public void input()
        {
            Console.Write("Luong thit = ");
            this.thit = double.Parse(Console.ReadLine());
            Console.Write("Luong banh pho = ");
            this.banh_pho = double.Parse(Console.ReadLine());
            Console.Write("Luong hanh = ");
            this.hanh = double.Parse(Console.ReadLine());
        }
    }
}
