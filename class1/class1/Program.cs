using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class Program
    {
        static void Main()
        {
            double pi = Math.PI;
            int oneThousand = (int)1000L;
            float piF = (float)pi;
            float oneThousandPi = piF * oneThousand;
            int rounded1000Pi = (int)Math.Round(oneThousandPi); //тут должно правильно округляться
            int integerPart = (int)oneThousandPi; //а тут нужно вычислить целую часть
            Console.WriteLine(rounded1000Pi);
            Console.WriteLine(integerPart);

            var a = 10.0;
            a += 0.5; //надо исправить, чтоб работало
            Console.WriteLine(a);

            var b = "15";
            var c = a + b; //тут что-то не так! надо поправить
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
