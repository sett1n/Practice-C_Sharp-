namespace Task_1
{
    class Program
    {
        public static void Main()
        {
            FileStream file = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line;
            int n = 0;
            double minNumber = double.MaxValue;
            double maxNumber = double.MinValue;
            while ((line = reader.ReadLine()) != null)
            {
                double currentNumber = Convert.ToDouble(line);
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                n++;
            }
            reader.Close();
            double sum = minNumber + maxNumber;
            Console.WriteLine($"Сумма наименьшего и наибольшего чисел равна - {sum}");
        }
    }
}