using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Program
    {
        public double FunctUnderZeroOrZero(double x)
        {
            return Math.Exp(x + 1);
        }
        public double FunctBetweenMinOneAndZeroOrZero()
        {
            return 1;
        }
        public double FunctOverZero(double x)
        {
            return Math.Exp(-x);
        }
        static void Main()
        {
            Console.WriteLine("Введите аргумент функции");
            double x = Convert.ToDouble(Console.ReadLine());
            var pr = new Program();
            if (x <= -1)
                Console.WriteLine("Значение функции = " + pr.FunctUnderZeroOrZero(x));
            else if (x > 0)
                Console.WriteLine("Значение функции = " + pr.FunctOverZero(x));
            else
                Console.WriteLine("Значение функции = " + pr.FunctBetweenMinOneAndZeroOrZero());
            Console.ReadKey();

            

        }
    }
}
