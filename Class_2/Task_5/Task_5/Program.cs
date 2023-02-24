Console.Write("Введите вещественное число A: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите целое число N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    double result = Math.Pow(a, i);
    Console.WriteLine("{0} в степени {1} = {2:F4}", a, i, result);
}