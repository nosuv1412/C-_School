using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_TH1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, x ;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());        
            if (a == 0) 
            Console.Write("Khong phai ptr bac nhat");
            else
            {
                Console.Write("Nhap b: ");
                b = float.Parse(Console.ReadLine());
                x = -b / a;
                Console.WriteLine("{0}x + ({1}) = 0",a ,b);
                Console.WriteLine("x = " + x);
            }
        }
    }
}
