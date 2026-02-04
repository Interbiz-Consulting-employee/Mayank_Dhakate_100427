namespace Multithread
{
    public class Program
    {
        static void Work()
        {
            Console.WriteLine("Thread Started");

            Thread.Sleep(5000); 

            Console.WriteLine("Thread Finished"); // Never runs
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Work);

            t1.Start();

            // Wait 2 seconds
            Thread.Sleep(2000);

            // Abort thread
            t1.Abort();

            Console.WriteLine("Thread Aborted");

            Console.ReadLine();
        }
    }
}
