using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7._2
{
    internal class Program
    {
        public void Circumstance(double x, double y)
        {
            if (y > 0.5 & y < 1.5 & x < 2)
                return true;
            else if (x > 2)
                return true;
            else
                return false;
        }
        static void Main()
        {
            var pr = new Program();
            Console.WriteLine("Введите координаты х, у");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pr.Circumstance(x, y));
            Console.ReadKey();
        }
    }
}
