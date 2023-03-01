using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст с цифрами: ");
        string text = Console.ReadLine(); 
        int product = 1;
        int minDigit = int.MaxValue; 

        foreach (char c in text)
        {
            if (char.IsDigit(c))
            {
                int digit = int.Parse(c.ToString());
                product *= digit;
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
            }
        }

        Console.WriteLine("Произведение цифр: {0}", product);
        Console.WriteLine("Минимальная цифра: {0}", minDigit);
    }
}