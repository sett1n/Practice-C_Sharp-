using System;

public struct AEROFLOT
{
    public string destination;
    public int flightNumber;
    public string aircraftType;
}

class Program
{
    static void Main(string[] args)
    {
        const int NUM_FLIGHTS = 7;
        AEROFLOT[] flights = new AEROFLOT[NUM_FLIGHTS];

        for (int i = 0; i < NUM_FLIGHTS; i++)
        {
            Console.Write($"Введите название пункта назначения рейса #{i + 1}: ");
            flights[i].destination = Console.ReadLine();

            Console.Write($"Введите номер рейса #{i + 1}: ");
            flights[i].flightNumber = int.Parse(Console.ReadLine());

            Console.Write($"Введите тип самолета для рейса #{i + 1}: ");
            flights[i].aircraftType = Console.ReadLine();

            Console.WriteLine();
        }

        Array.Sort(flights, (a, b) => a.flightNumber.CompareTo(b.flightNumber));

        Console.Write("Введите название пункта назначения: ");
        string destination = Console.ReadLine();

        bool foundFlight = false;

        for (int i = 0; i < NUM_FLIGHTS; i++)
        {
            if (flights[i].destination == destination)
            {
                Console.WriteLine($"Рейс #{flights[i].flightNumber}: тип самолета - {flights[i].aircraftType}");
                foundFlight = true;
            }
        }

        if (!foundFlight)
        {
            Console.WriteLine("Рейсы в данное место назначения не найдены.");
        }
    }
}