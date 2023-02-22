using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2.75;
            double c = 0.85;

            Console.WriteLine("Введите кол-во тетрадей: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во карандашей: ");
            double c2 = double.Parse(Console.ReadLine());

            double total = ((a * a2) + (c * c2));

            Console.WriteLine($"Цена: {total}") ;

            Console.ReadKey();
        }
    }
}
