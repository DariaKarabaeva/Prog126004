using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чсило n");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("значения функции :");
            for (double i = 0; i <= 2 * Math.PI; i+= Math.PI / n)
            {
                Console.WriteLine("Синус " + Math.Round(i * 57.2956, 2, MidpointRounding.AwayFromZero) + " = " + Math.Round(Math.Sin(i), 2, MidpointRounding.AwayFromZero));
            }
            Console.ReadKey();
        }
    }
}
