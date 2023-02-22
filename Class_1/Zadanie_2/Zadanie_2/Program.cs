using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод трехзначного числа
            Console.Write("Введите трехзначное число: ");
            int num = int.Parse(Console.ReadLine());

            // Разбиение числа на цифры
            int a = num / 100;
            int b = (num / 10) % 10;
            int c = num % 10;

            // Получение нового числа
            int newNum = b * 100 + c * 10 + a;

            // Вывод нового числа
            Console.WriteLine("Новое число: " + newNum);

            Console.ReadKey();
        }
    }
}
