Console.WriteLine("Введите признак транспортного средства: a - автомобиль, b - велосипед, c - мотоцикл, d - самолет, e - поезд.");
string name = Console.ReadLine();

switch (name)
{
    case "a":
        Console.WriteLine("Максимальная скорость Авто - 490,484 км/ч") ;
        break;
    case "b":
        Console.WriteLine("Максимальная скорость Велосипеда - 30 км/ч");
        break;
    case "c":
        Console.WriteLine("Максимальная скорость Мотоцикла - 350 км/ч");
        break;
    case "d":
        Console.WriteLine("Максимальная скорость Самолета - 8200,8 км/ч");
        break;
    case "e":
        Console.WriteLine("Максимальная скорость Поезда - 603 км/ч");
        break;
    default:
        Console.WriteLine("Неизвестный признак транспортного средства");
        break;

        Console.ReadKey();
}