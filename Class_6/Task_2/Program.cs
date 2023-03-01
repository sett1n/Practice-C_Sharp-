int p = 5;
double[] a = { -2.3, 3.7, 1.6, 4.8, -1.2 };
double sum = 0;

for (int i = 0; i < a.Length; i++)
{
    sum += a[i];
}
double average = sum / a.Length;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] < 0)
    {
        a[i] += 0.5;
    }
    else if (a[i] < average)
    {
        a[i] = 0.1;
    }
}

Console.WriteLine("Измененный массив:");
for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + " ");
}