using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            x = Convert.ToDouble(Console.ReadLine());
            y = 1 + Math.Sqrt(Math.Abs((x + (Math.Pow(x, 2)))) / Math.Pow(Math.Atan(x), 2)) - Math.Exp(Math.Sin(Math.Sqrt(x)));

            Console.WriteLine("Ответ: " + y);

            Console.ReadKey();
        }
    }
}
