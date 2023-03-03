using System.Text.RegularExpressions;

Console.WriteLine("Введите длину слова:");
int length = int.Parse(Console.ReadLine());

Console.WriteLine("Введите текст:");
string text = Console.ReadLine();

string pattern = $@"\b\w{{{length}}}\b";
Regex regex = new Regex(pattern);

Console.WriteLine($"Слова длины {length}:");
foreach (Match match in regex.Matches(text))
{
    Console.WriteLine(match.Value);
}