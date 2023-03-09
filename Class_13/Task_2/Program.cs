delegate double ArithmeticOperation(double a, double b);

class Program
{
    static void Main(string[] args)
    {
        ArithmeticOperation add = (a, b) => a + b;
        ArithmeticOperation sub = (a, b) => a - b;
        ArithmeticOperation mul = (a, b) => a * b;
        ArithmeticOperation div = (a, b) =>
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль!");
            }
            return a / b;
        };

        Console.Write("Введите первое число: ");
        double x;
        if (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Некорректное число!");
            return;
        }

        Console.Write("Введите второе число: ");
        double y;
        if (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Некорректное число!");
            return;
        }

        Console.Write("Введите операцию (+, -, *, /): ");
        string op = Console.ReadLine();

        double result;

        switch (op)
        {
            case "+":
                result = add(x, y);
                break;
            case "-":
                result = sub(x, y);
                break;
            case "*":
                result = mul(x, y);
                break;
            case "/":
                try
                {
                    result = div(x, y);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                break;
            default:
                Console.WriteLine("Некорректная операция!");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}