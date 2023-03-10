using System;

delegate void CalculationDelegate();

class Program
{
    static void Main(string[] args)
    {
        CalculationDelegate delegateInstance = new CalculationDelegate(CalculateSquare);
        delegateInstance += CalculateTriangle;

        try
        {
            UseDelegate(delegateInstance);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }
    }

    //2-ое задание

    static void UseDelegate(CalculationDelegate del)
    {
        del();
    }

    //2-ое задание

    static void CalculateSquare()
    {
        Console.WriteLine("Введите длину стороны квадрата:");

        double sideLength = double.Parse(Console.ReadLine());

        if (sideLength <= 0)
        {
            throw new ArgumentException("Длина стороны должна быть больше 0.");
        }

        double perimeter = 4 * sideLength;
        double area = sideLength * sideLength;

        Console.WriteLine($"Периметр: {perimeter}, Площадь: {area}");
    }

    static void CalculateTriangle()
    {
        Console.WriteLine("Введите длину стороны треугольника:");

        double sideLength = double.Parse(Console.ReadLine());

        if (sideLength <= 0)
        {
            throw new ArgumentException("Длина стороны должна быть больше 0.");
        }

        Console.WriteLine($"Длина стороны: {sideLength}");
    }
}