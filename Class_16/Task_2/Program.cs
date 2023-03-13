using Task_2.Model;

MyDictionary<int, string> dict = new MyDictionary<int, string>();
dict.Add(1, "Макс");
dict.Add(2, "Алекс");
dict.Add(3, "Тодд");

Console.WriteLine($"Количество: {dict.Counter}");
Console.WriteLine(dict.GetElem(3));