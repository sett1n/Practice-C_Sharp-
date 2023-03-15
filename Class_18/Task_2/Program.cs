using ClassLibrary;

namespace Task_2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите тип мебели: ");
            string type = Console.ReadLine();
            Console.WriteLine("Введите цвет мебели: ");
            string color = Console.ReadLine();
            Console.WriteLine("Введите размер мебели: ");
            double size = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену мебели: ");
            decimal cost = Convert.ToDecimal(Console.ReadLine());
            bool In_Stok = false;
            Furniture furniture = new Furniture(type, color, cost, In_Stok, size);

            Console.WriteLine("Вы хотите узнать есть ли этот товар на складе? 1 - да, 2 - нет");
            int checkNumber = Convert.ToInt32(Console.ReadLine());
            switch (checkNumber)
            {
                case 1:
                    bool whereFurniture = furniture.Check(In_Stok);
                    if (whereFurniture)
                    {
                        Console.WriteLine("Ваш товар есть на складе");
                        Console.WriteLine("Хотите забрать его со склада 1 - да, 2 - нет");
                        int needToRemoveCheck = Convert.ToInt32(Console.ReadLine());
                        if (needToRemoveCheck == 1)
                        {
                            furniture.RemoveFromStok();
                            Console.WriteLine($"Товар ожидает вас в приемочном центре {furniture.In_Stok}");
                        }
                        else if (needToRemoveCheck == 2)
                        {
                            Console.WriteLine("Товар остается на складе");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вашего товара нет на складе");
                        Console.WriteLine("Хотите поставить его на склад? 1 - да, 2 - нет");
                        int needToAddCheck = Convert.ToInt32(Console.ReadLine());
                        if (needToAddCheck == 1)
                        {
                            furniture.AddToStok();
                            Console.WriteLine($"Товар будет привезен на склад {furniture.In_Stok}");
                        }
                        else if (needToAddCheck == 2)
                        {
                            Console.WriteLine("Товара на складе не ожидается");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Выберите операцию: 1 - информация о товаре");
                    int furnitureOperation = Convert.ToInt32(Console.ReadLine());
                    switch (furnitureOperation)
                    {
                        case 1:
                            Console.Write($"|Тип мебели: {furniture.type}|\n" + $"|Цвет мебели: {furniture.color}|\n" + $"|Размер мебели: {furniture.size}\n|" + $"|Цена мебели: {furniture.cost}\n|" + $"|Ваш товар на складе: {furniture.In_Stok}\n|");
                            break;

                    }

                    break;
                default: Console.WriteLine("Неверный номер операции"); break;

            }
        }
    }
}