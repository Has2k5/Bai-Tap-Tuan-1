using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    public class PTBac1
    {
        protected double a, b;

        public PTBac1()
        {
           this.a = a;
           this.b = b;
        }

        public virtual void Giai()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Nghiem cua phuong trinh la: x = " + x);
            }
        }

        public class PTBac2 : PTBac1
        {
            private double c;
            public PTBac2(double a, double b, double c) : base()
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public override void Giai()
            {
                if (a == 0)
                {
                    base.Giai();
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine("Phuong trinh co nghiem kep: x = " + x);
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Phuong trinh co hai nghiem phan biet: x1 = " + x1 + ", x2 = " + x2);
                    }
                }
            }
        }

        public static class Program
        {
            public static void Main()
            {
                Console.WriteLine("Giai phuong trinh bac 2:");
                Console.Write("Nhap he so a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Nhap he so b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Nhap he so c: ");
                double c = double.Parse(Console.ReadLine());
                PTBac2 ptb2 = new PTBac2(a, b, c);
                ptb2.Giai();
            }
        }
    }
}

