namespace PractiseAsync1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("main progg started");
            Task t = Task.Run(() =>
            {
                Console.WriteLine("task started");
                Task.Delay(5000).Wait();
                Console.WriteLine("task done");

            });
            Console.WriteLine("Main thread continues....");
            Thread.Sleep(3000);
            Console.WriteLine("sleep done");
            await t;
            Console.WriteLine("All progg end");


        }
    }
}
