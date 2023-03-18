using System;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static int RearrangeNumber(int number)
        {
            int firstDigit = number / 100;
            int remainingDigits = number % 100;
            int rearrangedNumber = remainingDigits * 10 + firstDigit;
            return rearrangedNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите трех-значное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task<int> task1 = new Task<int>(() => RearrangeNumber(number));
            task1.Start();
            Task<int> task2 = Task.Factory.StartNew(() => RearrangeNumber(number));
            Task<int> task3 = Task.Run(() => RearrangeNumber(number));

            int[] results = Task.WhenAll(task1, task2, task3).GetAwaiter().GetResult();
            int finalResult = results[0];
            Console.WriteLine($"|Полученное число|: {finalResult}");

            Console.ReadLine();
        }
    }
}