using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1, ps2, ps3;
            ps1 = new PhanSo();
            ps1.input();
            ps2 = new PhanSo();
            ps2.input();
            ps3 = new PhanSo();
            ps3 = ps1 + ps2;
            Console.WriteLine(ps3.display());

        }
    }
}
