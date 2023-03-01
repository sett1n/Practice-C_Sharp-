using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        double result = Factorial(n - 3) / Factorial(n);

        Console.WriteLine("f(n) = {0}", result);
    }

    static double Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}