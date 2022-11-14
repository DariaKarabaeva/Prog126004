using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите через Enter значения x, y центра квадрата");
                double xCenter = Convert.ToInt32(Console.ReadLine());
                double yCenter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите через Enter значения x, y угла квадрата");
                double xCorner = Convert.ToInt32(Console.ReadLine());
                double yCorner = Convert.ToInt32(Console.ReadLine());
                double edge = Math.Sqrt(Math.Pow(xCorner - xCenter, 2) + Math.Pow(yCorner - yCenter, 2)) * (2 / Math.Sqrt(2));
                Console.WriteLine("Площадь квадрата равна - " + Math.Pow(edge, 2));
                Console.WriteLine("Периметр квадрата равен - " + 4 * edge);
                Console.Read();

            }
        }
    }
}
    

