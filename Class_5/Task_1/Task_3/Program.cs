static void TrianglePS(double a, out double P, out double S)
{
    P = 3 * a;
    S = a * a * Math.Sqrt(3) / 4;
}

double a1 = 2.5;
double a2 = 3.0;
double a3 = 4.2;

double P1, S1;
TrianglePS(a1, out P1, out S1);
Console.WriteLine($"Треугольник со стороной {a1}: P = {P1}, S = {S1}");

double P2, S2;
TrianglePS(a2, out P2, out S2);
Console.WriteLine($"Треугольник со стороной {a2}: P = {P2}, S = {S2}");

double P3, S3;
TrianglePS(a3, out P3, out S3);
Console.WriteLine($"Треугольник со стороной {a3}: P = {P3}, S = {S3}");