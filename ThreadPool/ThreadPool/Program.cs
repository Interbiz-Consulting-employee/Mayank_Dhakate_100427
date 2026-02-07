namespace ThreadPool
{
    using System;
    using System.Threading;
    public class Program
    {
        static void ServeCustomer(object CustomerId)
        {
            Console.WriteLine("Customer"+CustomerId+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("Customer id" + CustomerId + "Done");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Thread pool demo");
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(ServeCustomer,i);
            }
            Console.ReadLine();
        }
    }
}
