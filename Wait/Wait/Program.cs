namespace Wait
{
    using System;
    using System.Threading;
    
    public class Program
    {
        static object lockObj = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(WaitThread);
            Thread t2 = new Thread(SignalThread);

            t1.Start();
            Thread.Sleep(500); // Make sure t1 starts waiting
            t2.Start();
        }
        static void WaitThread()
        {
            lock (lockObj)
            {
                Console.WriteLine("Thread 1 is waiting...");
                Monitor.Wait(lockObj); // Wait for signal
                Console.WriteLine("Thread 1 resumed after signal!");
            }
        }
        static void SignalThread()
        {
            lock (lockObj)
            {
                Console.WriteLine("Thread 2 is sending signal...");
                Monitor.Pulse(lockObj); // Send signal to waiting thread
                Console.WriteLine("Thread 2 finished signaling.");
            }
        }
    }
}
