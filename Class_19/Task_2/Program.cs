using System.Text;
namespace Task_2
{
    class Program
    {
        static void Main()
        {
            int a = 2, b = 6;
            int number;

            Queue<int> fromAToB = new Queue<int>();
            Queue<int> lessThanA = new Queue<int>();
            Queue<int> moreThanB = new Queue<int>();

            using (StreamReader reader = new StreamReader(@"f.txt", Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    number = int.Parse(reader.ReadLine());

                    if (number >= a && number <= b)
                        fromAToB.Enqueue(number);
                    else if (number < a)
                        lessThanA.Enqueue(number);
                    else if (number > b)
                        moreThanB.Enqueue(number);
                }
            }

            Console.WriteLine("Числа в диапазоне [a,b]:");
            while (fromAToB.Count > 0)
            {
                Console.Write(fromAToB.Dequeue() + " ");
            }

            Console.WriteLine("\nЧисла меньше a:");
            while (lessThanA.Count > 0)
            {
                Console.Write(lessThanA.Dequeue() + " ");
            }

            Console.WriteLine("\nЧисла больше b:");
            while (moreThanB.Count > 0)
            {
                Console.Write(moreThanB.Dequeue() + " ");
            }
        }
    }
}
