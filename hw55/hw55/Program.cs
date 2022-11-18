using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Program
    {
        static double Count(double a)
        {
            return (Math.Sin(a));
        }

        public static void Main()
        {
            Console.WriteLine("Значение выражения =" + (Count(1 + (2 + (3 + (4))))));
            Console.ReadKey();
        }
    }
}
