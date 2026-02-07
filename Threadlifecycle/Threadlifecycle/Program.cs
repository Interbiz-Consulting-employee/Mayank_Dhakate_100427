namespace Threadlifecycle
{
    using System.Threading;
    public class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Method1);
            t.Start();
            Thread.SpinWait(1000);
            Console.WriteLine("Main thread stop");
        }
        static void Method1()
        {
            Console.WriteLine("Mehod start");
        }
    }
}
