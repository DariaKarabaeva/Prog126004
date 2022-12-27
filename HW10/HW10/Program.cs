using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число элементов массива");
            int n = int.Parse(Console.ReadLine());
            int[] massive = new int[n];
            var pr = new Program();
            for (int i = 0; i < n; i++)
            { 
                Console.Write($"\nВведите элемент массива под индексом {i}:\t");
                massive[i] = int.Parse(Console.ReadLine());
            }

                pr.OutPutM(massive);
            Console.ReadKey();

        }
        public void OutPutM(int[] massive)
        {
            Console.WriteLine(" Последовательность - ");
            for (int i = 0; i < massive.Length; i++)
                Console.Write(massive[i] + " ");
            Console.ReadKey();


        }
        
    }


    }

