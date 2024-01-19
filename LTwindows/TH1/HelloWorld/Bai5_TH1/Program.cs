using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_TH1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.Write("Nhap chieu dai: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            b = float.Parse(Console.ReadLine());

            float chuvi = (a + b) * 2;
            float dientich = a * b;
            Console.WriteLine("Chu vi la: " + chuvi);
            Console.WriteLine("Dien tich la: " + dientich);
        }
    }
}
