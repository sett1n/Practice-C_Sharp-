using Task_3.Model;

Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("h = ");
double h = double.Parse(Console.ReadLine());
double y;
for (double i = a; i <= b; i += h)
{
    Console.WriteLine("f ({0:f2}) = {1:f4}", i, Class1.f(i));
    Class1.f(i, out y);
    Console.WriteLine("f ({0:f2}) перегружен = {1:f4}", i, y);
}