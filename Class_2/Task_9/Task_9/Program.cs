int pricePerKg = int.Parse(Console.ReadLine());

for (int kg = 1; kg <= 10; kg++)
{
    int totalPrice = pricePerKg * kg;
    Console.WriteLine("{0} кг конфет стоят {1} рублей", kg, totalPrice);
}