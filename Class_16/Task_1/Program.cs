using Task_1.Model;

MyList<int> array = new MyList<int>();
array.Add(12);
array.Add(2);
array.Add(22);
Console.WriteLine($"Элемент: {array[0]}");
Console.WriteLine($"Количество элементов: {array.Count}");
int[] myArray = array.GetArray();
for (int i = 0; i < array.Count; i++)
{
    Console.WriteLine(myArray[i]);
}
