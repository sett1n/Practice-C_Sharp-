using static System.Math;

namespace Task_4
{
    class Program
    {
        static void Func(int x)
        {
            double result = 1 / Tan(x);
            Console.WriteLine($"Значение функции Ctg(x) при x = {x} будет равно {Round(result, 3)}");
        }

        static void Main(string[] args)
        {
            int firstNumber = 2;

            int secondNumber = 12;

            Parallel.For(firstNumber, secondNumber, Func);
        }
    }
}