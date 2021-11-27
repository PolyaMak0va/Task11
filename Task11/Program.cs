using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        // Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        // Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            Console.Write("Введите значение числа K: ");
            double k = double.Parse(Console.ReadLine());
            Console.Write("Введите значение числа B: ");
            double b = double.Parse(Console.ReadLine());
            MathEquation equation = new MathEquation(k, b);
            equation.Root();
            equation.Print();
            Console.ReadKey();
        }
        public struct MathEquation
        {
            public double k;
            public double b;

            public MathEquation(double k, double b)
            {

                this.k = k;
                this.b = b;
            }

            public double Root()
            {
                double x = 0;
                if (this.k != 0 && this.b != 0)
                {
                    x = (-this.b / this.k);
                    Console.WriteLine("Значение \"x\" равно {0}", x);
                }
                else if (this.b == 0)

                {
                    Console.WriteLine("Значение \"x\" равно {0}", x);
                    Console.WriteLine("Любое число для \"x\" является решением");
                }
                else
                {
                    Console.WriteLine("Подобное уравнение является противоречивым");
                }
                return x;
            }
            public void Print()
            {
                Console.WriteLine("Нажмите любую клавишу ");
            }
        }
    }
}
