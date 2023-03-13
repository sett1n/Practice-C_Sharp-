namespace Task_3
{
    internal class Program
    {
        static void FirstThread()
        {
            Console.WriteLine("Введите число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            Console.WriteLine("Поток запущен");
            for (int i = A; i <= N; i++)
            {
                temp += Convert.ToInt32(Math.Pow(A, N));
            }
            Console.WriteLine(temp);
        }

        static void SecondThread()
        {
            Console.WriteLine("Введите число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int temp1 = 1;
            int temp2 = 0;
            Console.WriteLine("Поток запущен!");
            for (int i = A; i <= N; i++)
            {
                temp1 += Convert.ToInt32(Math.Pow(A, N));
            }
            for (int i = A; i <= N; i++)
            {
                temp2 = temp2 * Convert.ToInt32(Math.Pow(A, N));
            }
            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
        }

        static void Main(string[] args)
        {

            Thread thr1 = new Thread(FirstThread);
            Thread thr2 = new Thread(SecondThread);

            thr1.Priority = ThreadPriority.Highest;
            thr2.Priority = ThreadPriority.Lowest;

            thr1.Start();
            thr1.Join();
            thr2.Start();
            thr2.Join();
            Console.ReadLine();
        }

    }
}
