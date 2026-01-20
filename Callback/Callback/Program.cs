namespace Callback
{
    public delegate void MyDelegate();
    class Program
    {
        static void OnworkCompleted()
        {
            Console.WriteLine("Work done");
        }
        static void dowork(MyDelegate callback)
        {
            Console.WriteLine("work progress...");
            Console.WriteLine("work finished");
            callback();
        }
        static void Main(string[] args)
        {
            MyDelegate del = OnworkCompleted;
            dowork(del);
        }
    }
}
