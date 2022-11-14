using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            int FirstSign = number / 100;
            int SecondSign = (number % 100) / 10;
            int ThirdSign = number % 10;
            int EndNumber = SecondSign * 100 + FirstSign * 10 + ThirdSign;
            Console.WriteLine($"Итоговое число = {EndNumber}");
            Console.ReadKey();

        }
    }
}
