using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х");
            double number = Convert.ToDouble(Console.ReadLine());
            double Function = (Math.Abs(number + 1) - Math.Abs(number - 1)) / Math.Abs(number);
            Console.WriteLine($"Значение функции = {Function}");
            Console.ReadKey();
        }
    }
}
