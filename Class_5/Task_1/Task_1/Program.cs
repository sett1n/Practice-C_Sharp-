try
{
    Console.Write("Введите значение X: ");
    double x = double.Parse(Console.ReadLine());

    double y1 = (Math.Sin(x) / (x - 5)) + Math.Pow(x, 3);
    Console.WriteLine($"a = {y1}");

    double y2 = Math.Log(x) - ((Math.Cos(x))/(3 * x + 6));
    Console.WriteLine($"b = {y2}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: Деление на ноль невозможно! ");
}
catch (FormatException)
{
    Console.WriteLine("Error: Введено недопустипое значение! ");
}
finally
{
    Console.WriteLine("Конец программы! ");
}