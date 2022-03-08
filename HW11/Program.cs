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
            double x = lineEq.Root();
            Console.WriteLine("x={0:f2}", x);
            Console.ReadKey();
        }
        struct LineEq
        {
            public double k;
            public double b;
            public LineEq(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
            public double Root()
            {
                double x=(0 - b) / k;
                return x;
            }
        }
    }
}
