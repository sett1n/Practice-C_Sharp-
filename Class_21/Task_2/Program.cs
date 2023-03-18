using static System.Math;

namespace Task_2
{
    class Program
    {
        static double firstExpression(double a, double b)
        {
            return ((Sin(4 * a)) / (1 + Cos(4 * a))) * ((Cos(2 * a)) / (1 + Cos(2 * a)));
        }
        static double secondExpression(double b)
        {
            return 1 / Tan((3 / 2) * PI - b);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Task[] tasks = new Task[2]
            {
                new Task(() => Console.WriteLine($"1 задача: {firstExpression(a, b)}")),
                new Task(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"2 задача: {secondExpression(b)}");
                })
            };
            foreach (var task in tasks)
            {
                task.Start();
                task.Wait();
            }
        }
    }
}