using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            var directory = AppDomain.CurrentDomain.BaseDirectory;
            directory = directory.Substring(0, directory.IndexOf("\\bin"));

            Console.Write("Введите имя файла: ");
            var file = Console.ReadLine();
            var lines = File.ReadLines(directory + "\\" + file);
            
            Console.Write("Введите минимальную длину слова: ");
            var len = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Обрабатываю текст");

            foreach (var word in lines)
                if (word.Length >= len)
                {
                    if (dict.ContainsKey(word))
                        dict[word]++;
                    else
                    {
                        dict[word] = 1;
                        Console.Write("+");
                    }
                }

            var results = dict
                .OrderBy(pair => pair.Key)
                .Select(pair => $"{pair.Key} {pair.Value}")
                .ToArray();
            File.WriteAllLines(directory + "\\result.txt", results);

            Console.WriteLine("\nОбработка текста завершена");
            Console.WriteLine($"Слов списке: {dict.Count}");
        }
    }
}