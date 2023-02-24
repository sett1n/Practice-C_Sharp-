int A = 1; // начальное значение диапазона
int B = 20; // конечное значение диапазона
int X = 3; // цифра на которую должно заканчиваться число
int Y = 7; // цифра на которую должно заканчиваться число

int i = A;

while (i <= B)
{
    if (i % 10 == X || i % 10 == Y)
        Console.WriteLine(i);
    i++;
}

i = A;

do
{
    if (i % 10 == X || i % 10 == Y)
        Console.WriteLine(i);
    i++;
} while (i <= B);

for (i = A; i <= B; i++)    
{
    if (i % 10 == X || i % 10 == Y)
        Console.WriteLine(i);
}