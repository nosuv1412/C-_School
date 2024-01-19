using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        public static bool check(int n)
        {
            if (n <= 1)
                return false;
            int x = (int)(n / 2);
            for (int i = 2; i < x; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            if (check(n))
                Console.WriteLine("N la so nguyen to");
            else
                Console.WriteLine("N khong la so nguyen to");
        }
    }
}
