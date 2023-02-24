double x, y;

Console.Write("Введите значение x: ");
x = double.Parse(Console.ReadLine());

if (x >= 1 && x <= 3)
{
    y = 2 * Math.Pow(x, 2) - 3 * Math.Exp(Math.Sin(x));
}
else if (x > 3)
{
    y = 3 * Math.Tan(x);
}
else
{
    Console.WriteLine("Ошибка: x должен быть больше или равен 1");
    return;
}

Console.WriteLine("Значение функции y = {0}", y);

Console.ReadLine();