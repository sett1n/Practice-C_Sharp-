using Task_1._2;

Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("h = ");
double h = double.Parse(Console.ReadLine());

for (double i = a; i <= b; i += h)
    Console.WriteLine("f ({0:f2}) = {1:f4}", i, Function.f(i)); 