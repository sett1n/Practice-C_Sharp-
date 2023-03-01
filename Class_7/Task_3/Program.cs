using System.Text;

Console.Write("Введите предложение: ");
string sent = Console.ReadLine();
string[] words = sent.Split(" ");

Console.WriteLine("1------------------------");
string memory = words[0];
words[0] = words[words.Length - 1];
words[words.Length - 1] = memory;
Console.WriteLine(string.Join(" ", words));

Console.WriteLine("2------------------------");
words[1] = words[1] + words[2];
words[2] = "";
Console.WriteLine(string.Join(" ", words));

Console.WriteLine("3------------------------");
words[3] = new String(words[3].Reverse().ToArray());
Console.WriteLine(string.Join(" ", words));

Console.WriteLine("4------------------------");
words[0] = words[0].Substring(2);
Console.WriteLine(string.Join(" ", words));