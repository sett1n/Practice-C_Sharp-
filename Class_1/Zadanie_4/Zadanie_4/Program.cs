using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершины A: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты вершины B: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты вершины C: ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            double p = a + b + c; //перимтр

            double P = p / 2; //полупериметр

            double s = Math.Sqrt(P * (P - a) * (P - b) * (P - c)); //площадь треугольника

            Console.WriteLine("Периметр треугольника: " + p);
            Console.WriteLine("Площадь треугольника: " + s);

            Console.ReadKey();
        }
    }
}
