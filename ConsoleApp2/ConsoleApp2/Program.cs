using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("А.С.Пушкин");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Я помню чудное мгновенье");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Я помню чудное мгновенье, передо мной явилась ты, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("как мимолетное виденье, как гений чистой красоты");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
