using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class PhanSo
    {
        private double tu, mau;

        public PhanSo()
        {
        }

        public PhanSo(double tu, double mau)
        {
            this.tu = tu;
            this.mau = mau;
        }

        public double UCLN(double a, double b)
        {
            a = Math.Abs(this.tu);
            b = Math.Abs(this.mau);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }

        public PhanSo rut_gon()
        {
            PhanSo rutgon = new PhanSo();
            double uoc = UCLN(this.tu, this.mau);
            if (uoc != 0)
            {
                rutgon.tu = tu / uoc;
                rutgon.mau = mau / uoc;
            }
            else
            {
                rutgon.tu = tu;
                rutgon.mau = mau;
            }
            return rutgon;
        }

        public static PhanSo operator +(PhanSo phanSo1, PhanSo phanSo2) // toán tử cộng 2 phân  số
        {
            PhanSo phansoKQ = new PhanSo();
            phansoKQ.tu = phanSo1.tu * phanSo2.mau + phanSo2.tu * phanSo1.mau;
            phansoKQ.mau = phanSo1.mau * phanSo2.mau;
            return phansoKQ;
        }
        public static PhanSo operator -(PhanSo phanSo1, PhanSo phanSo2) // toán tử chia 2 phân số
        {
            PhanSo phansoKQ = new PhanSo();
            phansoKQ.tu = phanSo1.tu * phanSo2.mau - phanSo2.tu * phanSo1.mau;
            phansoKQ.mau = phanSo1.mau * phanSo2.mau;
            return phansoKQ;
        }
        public static PhanSo operator *(PhanSo phanSo1, PhanSo phanSo2) // toán tử * 2 phân số
        {
            PhanSo phansoKQ = new PhanSo();
            phansoKQ.tu = phanSo1.tu * phanSo2.tu;
            phansoKQ.mau = phanSo1.mau * phanSo2.mau;
            return phansoKQ;
        }
        public static PhanSo operator /(PhanSo phanSo1, PhanSo phanSo2)// toán tử / 2 phân số
        {
            PhanSo phansoKQ = new PhanSo();
            phansoKQ.tu = phanSo1.tu * phanSo2.mau;
            phansoKQ.mau = phanSo1.mau * phanSo2.tu;
            return phansoKQ;
        }

        public void input()
        {
            Console.Write("Tu so = ");
            this.tu = double.Parse(Console.ReadLine());
            Console.Write("Mau so = ");
            this.mau = double.Parse(Console.ReadLine());
        }

        public void display()
        {
            if (this.mau == 0)
                Console.WriteLine("Day khong phai phan so!");
            else
                Console.WriteLine("{0}/{1}", this.tu, this.mau);
        }


    }
}
