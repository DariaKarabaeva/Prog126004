using System;

public class Program
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("А.С.Пушкин");
        Console.WriteLine("");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Я вас любил");
        Console.WriteLine("");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Я вас любил: любовь еще, быть может");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("В душе моей угасла не совсем");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Но пусть она вас больше не тревожит,");
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Я не хочу печалить вас ничем");
        Console.ResetColor();
        Console.ReadKey();
    }
}
