using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK01
{
    internal class Program
    {
        static void Main(string[] args)
        {Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("А.С.Пушкин");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Я помню чудное мгновенье");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Я помню чудное мгновенье");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Передо мной явилась ты");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Как мимолетное виденье");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Как гений чистой красоты");
            Console.ResetColor();

            Console.ReadLine();
            
        }
    }
}
