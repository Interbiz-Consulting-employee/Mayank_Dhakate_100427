namespace Delegate
{
    public class Program
    {
        delegate void MyDelegate();
        static void sayHello()
        {
            Console.WriteLine("Hello from delegate!");
        }
        static void Main(string[] args)
        {
            MyDelegate del = sayHello;
            del();
        }
    }
}
