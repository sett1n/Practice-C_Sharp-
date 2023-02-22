using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z1, a, z2, p;

            Console.WriteLine("Введите значение a: ");
            a = double.Parse(Console.ReadLine());

            z1 = ((Math.Sin(4 * a)) / (1 + Math.Cos(4 * a))) * ((Math.Cos(2 * a)) / (1 + Math.Cos(2 * a)));

            Console.WriteLine("Ответ первого уравнения: {0}",z1);

            p = 3.14;

            z2 = (Math.Tan(((3 / 2) * p - a)));

            Console.WriteLine("Ответ второго уравнения: {0}", z2);

            Console.ReadKey();  
        }
    }
}
