namespace Task_1
{
    class Program
    {
        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 1 выводит " + i);
            }
        }

        static void SecondThread()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine("Поток 2 выводит " + i);
            }
        }

        static void ThirdThread()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine("Поток 3 выводит " + i);
            }
        }

        static void Main(string[] args)
        {
            object locker = new object();

            Thread thr1 = new Thread(FirstThread);
            Thread thr2 = new Thread(SecondThread);
            Thread thr3 = new Thread(ThirdThread);

            thr1.Priority = ThreadPriority.Highest;
            thr2.Priority = ThreadPriority.AboveNormal;
            thr3.Priority = ThreadPriority.Lowest;

            thr1.Start();
            thr2.Start();
            thr3.Start();

            Console.ReadLine();
        }
    }
}