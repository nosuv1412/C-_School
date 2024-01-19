using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_TH3
{
    class Pho
    {
        private double thit, banhpho, hanh;

        public Pho() { }
        public Pho(double thit, double banhpho, double hanh)
        {
            this.thit = thit;
            this.banhpho = banhpho;
            this.hanh = hanh;
        }

        public double tinhtien()
        {
            return thit * 15000 + banhpho * 10000 + hanh * 2000;
        }

        public void display()
        {
            Console.WriteLine(thit + "\t" + banhpho + "\t\t" + hanh + "\t" + tinhtien());
        }

        public void input()
        {
            Console.Write("Luong thit = ");
            thit = double.Parse(Console.ReadLine());
            Console.Write("Luong banh pho = ");
            banhpho = double.Parse(Console.ReadLine());
            Console.Write("Luong hanh = ");
            hanh = double.Parse(Console.ReadLine());
        }
    }
}
