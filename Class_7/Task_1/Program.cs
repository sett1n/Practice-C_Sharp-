static class program
{
    public static void Main()
    {
        string str1;
        char[] arr1;
        int l, i;
        l = 0;
        char ch;
        Console.Write("Введите слово: ");
        str1 = Console.ReadLine();
        l = str1.Length;
        arr1 = str1.ToCharArray(0, l);

        Console.Write("Ответ: ");
        for (i = 0; i < l; i++)
        {
            ch = arr1[i];
            if (Char.IsLower(ch))
                Console.Write(Char.ToUpper(ch));
            else
                Console.Write(Char.ToLower(ch));
        }
    }
}