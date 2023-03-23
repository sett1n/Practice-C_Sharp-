using Task_1;

Console.WriteLine("Введите значение полей класса!");
Console.Write("a = ");
double a = int.Parse(Console.ReadLine());
Console.Write("b = ");
double b = int.Parse(Console.ReadLine());
MyClass A = new MyClass(a, b);

if (A.Method1() > A.Method2())
{
    Console.WriteLine($"Точка 'a' принимает наибольшее значение = {A.Method1()}");
}
else if (A.Method1() < A.Method2())
{
    Console.WriteLine($"Точка 'b' принимает наибольшее значение = {A.Method2()}");
}
else
{
    Console.WriteLine("Значения 'a' и 'b' равны.");
}

Console.ReadKey();

namespace Task_1
{
    public class MyClass
    {
        public double a, b;
        public MyClass(double x1, double x2)
        {
            a = x1;
            b = x2;
        }
        /// <summary>
        /// Возвращает результат вычисления функции f(a) = a^3 - sin(a).
        /// </summary>
        /// <returns>Значение функции f(a).</returns>
        public double Method1()
        {
            return Math.Pow(a, 3) - Math.Sin(a);
        }
        /// <summary>
        /// Возвращает результат вычисления функции f(b) = b^3 - sin(b).
        /// </summary>
        /// <returns>Значение функции f(b).</returns>
        public double Method2()
        {
            return Math.Pow(b, 3) - Math.Sin(b);
        }
    }
}