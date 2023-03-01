using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер матрицы N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите диапазон значений a и b: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите значение C: ");
        int c = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        Random random = new Random();

        // Заполнение матрицы случайными числами
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(a, b + 1);
            }
        }

        // Вывод исходной матрицы на консоль
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Вычисление суммы квадратов элементов, больших C
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > c)
                {
                    sum += matrix[i, j] * matrix[i, j];
                }
            }
        }
        Console.WriteLine("Сумма квадратов элементов, больших {0}: {1}", c, sum);

        // Вычисление среднего арифметического элементов каждой строки
        Console.WriteLine("Среднее арифметическое элементов каждой строки:");
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            double rowAverage = (double)rowSum / n;
            Console.WriteLine("Строка {0}: {1}", i, rowAverage);
        }
    }
}