    Console.WriteLine("Введите значение полей класса!");
    Console.Write("a= ");
    double a = int.Parse(Console.ReadLine());
    Console.Write("b= ");
    double b = int.Parse(Console.ReadLine());
    MyClass A = new MyClass(a, b);
    Console.WriteLine($"Значение по первому методу = {A.Method1()}");
    Console.WriteLine($"Значение по второму методу = {A.Method2()}");
    Console.ReadKey();

public class MyClass
{
    public double a, b; 
    public MyClass(double _a, double _b)
    {
        a = _a;
        b = _b; 
    }   
    public double Method1 ()
    {
        return a / b;
    }
    public double Method2 ()
    {
        return Math.Pow(a + b, 1 / 3);
    }
}
