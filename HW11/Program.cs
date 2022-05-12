using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b.
        //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.Для решения уравнения предусмотреть метод Root.
        //Создать экземпляр разработанной структуры.Осуществить использование экземпляра в программе.

        static void Main(string[] args)
        {
            Console.WriteLine("Для решения линейного уравнение 0 = kx + b");
            Console.Write("Введите k=");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b=");
            double b = Convert.ToDouble(Console.ReadLine());
            LineEq lineEq = new LineEq(k, b);

            lineEq.Root();
            Console.ReadKey();
        }
        struct LineEq
        {

            public double K { get; set; }
            public double B { get; set; }

            public LineEq(double k, double b)
            {
                K = k;
                B = b;
            }
            public void Root()
            {

                if (K == 0 && B == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечное количество решени");
                }
                else
                {
                    if (K == 0)
                    {
                        Console.WriteLine("Уравнение не имеет решения");
                    }
                    else
                    {
                        double x = -B / K;
                        Console.WriteLine("Корень уровнения х = {0}", x);
                    }
                }
            }
        }
    }
}
