using System;

namespace Bai1
{
    class Program
    {
        const double pi = 3.14;
        public static double chuvi(double r)
        {
            return (2 * pi * r);
        }

        public static double dientich(double r)
        {
            return Math.Round((pi * r * r), 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap r = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi hinh tron: " + chuvi(r));
            Console.WriteLine("Dien tich hinh tron: " + dientich(r));
        }
    }
}

