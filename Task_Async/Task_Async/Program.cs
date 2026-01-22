namespace Task_Async
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int result = 3 + 3;
            Console.WriteLine(result);
            Method();
        }
        static async Task Method()
        {
            Console.WriteLine("hi");
        }
    }
}
