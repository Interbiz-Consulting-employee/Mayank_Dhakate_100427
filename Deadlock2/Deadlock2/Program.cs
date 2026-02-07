namespace Deadlock2
{
    using System.Threading;
    public class Program
    {
        static object lock1=new object();
        static object lock2=new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            t1.Start();
            t2.Start();
            
        }
        static void Method1()
        {
            lock (lock1)
            {
                Console.WriteLine("Thread1:Locked lock1");
                Thread.Sleep(1000);
                lock (lock2)
                {
                    Console.WriteLine("Thread1;locked lock2");
                }
            }
        }
        static void Method2()
        {
            lock (lock2)
            {
                Console.WriteLine("Thread2:Locked lock1");
                Thread.Sleep(1000);
                lock (lock1)
                {
                    Console.WriteLine("Thread2;locked lock2");
                }
            }
        }
    }
}

