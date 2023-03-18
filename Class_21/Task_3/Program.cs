using System;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static int SumOfDigits(int number)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            return firstDigit + secondDigit;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task<int> task1 = Task.Run(() => SumOfDigits(number));
            Task task2 = task1.ContinueWith(task => Console.WriteLine("Сумма цифр: " + task.Result));

            Task.WaitAll(task1, task2);

            Console.ReadLine();
        }
    }
}
