using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_TH3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pho[] pho = new Pho[10];
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap du lieu cho bat pho thu {0}:", i + 1);
                    try
                    {
                        pho[i] = new Pho();
                    }
                    catch (OutOfMemoryException e)
                    {

                        Console.WriteLine(e);
                    }

                    pho[i].input();
                }
                Console.WriteLine("\nThong tin bat pho vua nhap la:");
                Console.WriteLine("STT\tThit\tBanh pho\tHanh\tThanh tien");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(i + 1 + "\t");
                    pho[i].display();
                }

                double max = pho[0].tinhtien(), min = pho[0].tinhtien();
                for (int i = 1; i < n; i++)
                {
                    if (pho[i].tinhtien() > max)
                        max = pho[i].tinhtien();
                    if (pho[i].tinhtien() < min)
                        min = pho[i].tinhtien();
                }

                for (int i = 0; i < n; i++)
                {
                    if (pho[i].tinhtien() == max)
                        Console.WriteLine("Bat pho thu {0} co gia thap nhat la {1}", i + 1, pho[i].tinhtien());
                    if (pho[i].tinhtien() == min)
                        Console.WriteLine("Bat pho thu {0} co gia cao nhat la {1}", i + 1, pho[i].tinhtien());
                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
