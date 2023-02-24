Console.Write("Введите расстояние в метрах: ");

int Meters = int.Parse(Console.ReadLine()); 

int kilometers = Meters / 1000; // делим расстояние в метрах на 1000, чтобы получить количество полных километров

Console.WriteLine($"Расстояние {Meters} метров составляет {kilometers} полных километров");