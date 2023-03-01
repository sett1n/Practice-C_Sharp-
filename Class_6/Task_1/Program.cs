double[] numbers = { 2.5, 3.7, 1.6, 4.8, 2.1 };
double sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

double average = sum / numbers.Length;

Console.WriteLine("Среднее арифметическое: " + average);