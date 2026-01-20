namespace Async1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Progg started");
            Task t = Task.Run(() =>
            {
                Console.WriteLine("Task started");
                Task.Delay(9000).Wait();
                Console.WriteLine("task end");
            });
            Console.WriteLine("Main thread continue..");
            await t;
            Console.WriteLine("progg end");
            
            
        }
    }
}
