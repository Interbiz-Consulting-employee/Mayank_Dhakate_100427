namespace Action_delegate
{
     class Program
    {
        static void Main(string[] args)
        {
            //Action<string> printmessage = message => Console.WriteLine("message typed"+message);
            //printmessage("hello");
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine(isEven(12));
        }
    }
}
