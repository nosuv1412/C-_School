using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        public static bool check(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            if (check(n))
                Console.WriteLine("N la so chan");
            else
                Console.WriteLine("N la so le");
        }
    }
}