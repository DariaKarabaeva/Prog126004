using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4,5,6 или 7 степень");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int bound = 9 * (n1(9, n));
            for (int i = 10; i < bound; i++)
            {
                if (Counter(i, n))
                {
                    s += i;
                    Console.WriteLine($"Число {i} равно сумме каждой цифры, возведенной в степень {n} ");

                }
            }
            Console.WriteLine($"Сумма получившихся чисел равна {s} ");
            Console.ReadKey();
        }

        static bool Counter(int num, int n)
        {
            int a1 = num;

            int sum = 0;

            bool b = false;

            int[] temp = new int[num.ToString().Length];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = num % 10;
                num /= 10;
            }
            Array.Reverse(temp);

            foreach (int i in temp)
            {
                sum += n1(i, n);
            }
            if (sum == a1)
            {
                b = true;
            }

            return b;
        }
        static int n1(int number, int n)
        {
            int temp = number;
            for (int i = 1; i < n; i++)
                number *= temp;

            return number;
        }
    }
}