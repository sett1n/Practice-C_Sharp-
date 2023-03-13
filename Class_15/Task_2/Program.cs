namespace Task_2
{
    class Program
    {
        static void mythread1()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine("Поток 1 - " + sum);
                Thread.Sleep(50);
            }
        }
        static void mythread2()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine("Поток 2 - " + sum);
                Thread.Sleep(50);
            }
        }
        static void Main(string[] args)
        {
            Thread thr1 = new Thread(mythread1);
            Thread thr2 = new Thread(mythread2);

            thr1.Priority = ThreadPriority.Highest;
            thr2.Priority = ThreadPriority.AboveNormal;
            thr1.Start();
            thr2.Start();
            Console.ReadLine();
        }
    }
}