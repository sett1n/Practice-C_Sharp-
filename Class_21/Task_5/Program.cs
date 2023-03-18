using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void MultAndSum(int x, ParallelLoopState pls)
        {
            long mult = 1;
            for (int i = 1; i <= x; i++)
            {
                mult *= i;
            }
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }

            if ((mult > 300) && (sum > 300))
            {
                pls.Break();
            }
            Console.WriteLine($"Сумма: {sum}, Произведение: {mult}");

        }

        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 74, 23, 65, 98 }, MultAndSum);
            if (!result.IsCompleted)
                Console.WriteLine($"Прерываение на {result.LowestBreakIteration}");

        }
    }
}
