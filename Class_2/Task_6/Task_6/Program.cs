double A = 0.0;
double B = Math.PI / 4.0;
int M = 10;
double H = (B - A) / M;

Console.WriteLine("Вычисление значений функции F(x) на отрезке [{0}, {1}] в {2} точках:", A, B, M);

for (int i = 0; i <= M; i++)
{
    double x = A + i * H;
    double fx = Math.Tan(x);
    Console.WriteLine("F({0:f2}) = {1:f2}", x, fx);
}

Console.ReadLine();