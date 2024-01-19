using System;

namespace btap_lop
{
    class Program
    {
        static void Main(string[] args)
        {
            PHO[] pho = new PHO[10];
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap du lieu cho bat pho thu {0}:", i+1);
                    try
                    {
                        pho[i] = new PHO();
                    }
                    catch (OutOfMemoryException e)
                    {

                        Console.WriteLine(e);
                    }

                    pho[i].input();
                }
                Console.WriteLine("\nThong tin 10 bat pho vua nhap la:");
                Console.WriteLine("STT\tThit\tBanh pho\tHanh\tThanh tien");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(i + 1 + "\t");
                    pho[i].display();
                }

                double max = pho[0].tinh_tien(), min = pho[0].tinh_tien();
                for (int i = 1; i < n; i++)
                {
                    if (pho[i].tinh_tien() > max)
                        max = pho[i].tinh_tien();
                    if (pho[i].tinh_tien() < min)
                        min = pho[i].tinh_tien();
                }

                for (int i = 0; i < n; i++)
                {
                    if (pho[i].tinh_tien() == max)
                        Console.WriteLine("Bat pho thu {0} co gia thap nhat la {1}", i + 1, pho[i].tinh_tien());
                    if (pho[i].tinh_tien() == min)
                        Console.WriteLine("Bat pho thu {0} co gia cao nhat la {1}", i + 1, pho[i].tinh_tien());
                }


            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
