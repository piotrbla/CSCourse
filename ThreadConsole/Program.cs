
namespace ThreadConsole
{
    internal class Program
    {
        private static void DoWork2()
        {
            Console.WriteLine("Thread2 started");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Thread 222222222222 working\n");
                Thread.Sleep(100);
            }
            Console.WriteLine("Thread2 finished");
        }
        private static void DoWork1()
        {
            Console.WriteLine("Thread1 started");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Thread 111111111111 working\n");
                Thread.Sleep(100);
            }
            Console.WriteLine("Thread1 finished");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start threads");

            //Thread t1 = new Thread(DoWork1);
            //Thread t2 = new Thread(DoWork2);
            //t1.Start();
            //t2.Start();


            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork3);
                ThreadPool.QueueUserWorkItem(DoWork3);
                //Thread.Sleep(100);
            }

            Console.WriteLine("Threads started");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void DoWork3(object? state)
        {
            Console.WriteLine("Thread3 started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread3 id: " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            Console.WriteLine("Thread3 finished");
        }
    }
}
