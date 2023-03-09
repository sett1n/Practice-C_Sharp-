using System;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        StringOperation operation;

        operation = RemoveSpaces;
        operation += Reverse;
        operation += ToUpperCase;

        operation(str);

        Console.ReadKey();
    }

    static void RemoveSpaces(string str)
    {
        string result = str.Replace(" ", "");
        Console.WriteLine("Строка без пробелов: " + result);
    }

    static void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string result = new string(charArray);
        Console.WriteLine("Перевернутая строка: " + result);
    }

    static void ToUpperCase(string str)
    {
        string result = str.ToUpper();
        Console.WriteLine("Строка в верхнем регистре: " + result);
    }
    delegate void StringOperation(string str);
}