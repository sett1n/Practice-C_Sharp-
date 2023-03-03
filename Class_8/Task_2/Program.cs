using System.Text.RegularExpressions;

Console.WriteLine("Введите слово для поиска:");
string word = Console.ReadLine();

Console.WriteLine("Введите текст:");
string text = Console.ReadLine();

string pattern = $@"\b{word}\b";
Regex regex = new Regex(pattern);

int count = regex.Matches(text).Count;
if (count > 0)
{
    Console.WriteLine($"Слово '{word}' встречается в тексте {count} раз(а).");
}
else
{
    Console.WriteLine($"Слово '{word}' не найдено в тексте.");
}