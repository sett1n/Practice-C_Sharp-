int[,] income = new int[10, 12]; // создание двумерного массива доходов

// заполнение массива случайными значениями
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 12; j++)
    {
        income[i, j] = rnd.Next(1000, 10000); // случайное значение от 1000 до 9999
    }
}

int targetIncome = 50000; // заданное значение дохода
int totalIncomeInSeptember = 0;

// расчет общего дохода в сентябре
for (int i = 0; i < 10; i++)
{
    totalIncomeInSeptember += income[i, 8]; // 8-й элемент массива соответствует сентябрю
}

// проверка условия после выполнения расчетов
if (totalIncomeInSeptember > targetIncome)
{
    Console.WriteLine("Общий доход фирмы в сентябре превысил {0}", targetIncome);
}
else
{
    Console.WriteLine("Общий доход фирмы в сентябре НЕ превысил {0}", targetIncome);
}