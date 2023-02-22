using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int num1 = number / 10;
            int num2 = number % 10;

            int sum = num1 + num2;

            Console.WriteLine($"Сумма цифр числа {number} равна {sum}.");

            Console.ReadKey();
        }
    }
}
