namespace Aync_Method
{
    internal class Program
    {
        public static async Task method1()
        {
            Console.WriteLine("task 1 started");
            await Task.Delay(4000);
            Console.WriteLine("task 1 end");
        }
        public static async Task method2()
        {
            Console.WriteLine("task 2 started");
           await  Task.Delay(4000);
            Console.WriteLine("task 2 end");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main progg started");
            Task t1 = method1();
            Task t2 = method2();
            Task.WhenAll(t1, t2).Wait();
            Console.WriteLine("Main progg end");
           
        }
    }
}
