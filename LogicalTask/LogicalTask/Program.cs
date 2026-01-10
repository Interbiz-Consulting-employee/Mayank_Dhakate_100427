namespace LogicalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            task t = new task();
            char result=t.Show(['x', 'x', 'y','y'], 'z');
            Console.WriteLine(result);
        }
    }
}
