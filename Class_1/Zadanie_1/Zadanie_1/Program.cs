using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            float num1 = float.Parse(Console.ReadLine()); //Ввод первого числа
           
            Console.Write("b= ");
            float num2 = float.Parse(Console.ReadLine()); //Ввод второго числа

            float total = num2 * num1; //Произведение чисел

            Console.WriteLine(num1 + "*" + num2 + "=" + total);

            Console.ReadKey();
        }
    }
}
