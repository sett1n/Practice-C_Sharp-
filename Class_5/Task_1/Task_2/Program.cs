try
{
    Console.Write("Введите вещественное х: ");
    double x = double.Parse(Console.ReadLine());
    double f;
    if (x > -3 && x < 3)
    {
        f = 2 / x;
        Console.WriteLine($"f(x) = {f}");
    }
    else if (x <= -3)
        Console.WriteLine("f(x) = " + 5 * x);
    else throw new Exception("Ошибка: выход из диапазона допустимых значений х!");
}
catch (Exception fx)
{
    Console.WriteLine(fx.Message);
}
finally
{
    Console.WriteLine("Конец программы!");
}
Console.ReadLine();