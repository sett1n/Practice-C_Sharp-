int number = int.Parse(Console.ReadLine());

bool isEven = (number % 2 == 0); // проверяем, является ли число четным
bool isTwoDigit = (number >= 10 && number <= 99); // проверяем, является ли число двузначным

bool result = isEven && isTwoDigit; // проверяем истинность высказывания

Console.WriteLine(result);