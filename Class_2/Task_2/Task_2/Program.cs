int M, N;

Console.Write("Введите значение M: ");
M = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
N = int.Parse(Console.ReadLine());

if (M % N == 0)
{
    Console.WriteLine("Частное от деления M на N: {0}", M / N);
}
else
{
    Console.WriteLine("M на N нацело не делится");
}

Console.ReadLine();