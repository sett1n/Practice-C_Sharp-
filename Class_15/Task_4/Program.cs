using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static int sum = 0;
        static int n = 8;
        static int a = 0;
        static int b = 3;
        static Barrier barrier = new Barrier(2, (b) =>
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(" ");
            }

        });

        static void Main(string[] args)
        {
            Thread Thread = new Thread(new ThreadStart(Count));
            Thread.Start();

            for (int i = 0; i < n; i++)
            {
                a += b;
                if (a % 2 == 0)
                {
                    Console.WriteLine("Главный поток: ");
                    Console.WriteLine(sum + a);
                    barrier.SignalAndWait();
                }
            }
            Console.ReadLine();
        }

        public static void Count()
        {
            Random random = new Random();
            b = random.Next(3);
            for (int i = 0; i < n; i++)
            {
                a += b;
                if (a % 2 == 0)
                {
                    Console.WriteLine("Второй поток: ");
                    Console.WriteLine(sum + a);

                    barrier.SignalAndWait();
                }
            }
        }
    }
}