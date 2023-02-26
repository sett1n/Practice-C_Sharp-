using Task_2;

Console.WriteLine("1 ->  создание механизма 2 -> создание узла 3 -> создание изделия ");
int total = int.Parse(Console.ReadLine());

if (total == 1)
{
    Mechanism mechanism = new Mechanism();
    mechanism.Output();
}
else if (total == 2)
{
    Yzel yzel = new Yzel();
    yzel.Output();
}
else if (total == 3)
{
    Product product = new Product();
    product.Output();
}
else 
{
    Console.WriteLine("Некорректный ввод.");
}
