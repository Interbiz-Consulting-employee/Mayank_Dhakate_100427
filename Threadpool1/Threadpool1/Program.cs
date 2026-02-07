namespace Threadpool1
{
    using System.Threading;
    public class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Mymethod));


            }
            Console.ReadLine();
        }
        static void Mymethod(object obj)
        {
            Thread t = Thread.CurrentThread;
            string message = $"Background:{t.IsBackground},{t.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
    }

