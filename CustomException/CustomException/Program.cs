namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 9;
                int y = 4;
                if(x % 2 > 0)
                {
                    throw new AddException();
                }
                int result =  x - y;
                Console.WriteLine(result);
            }
            catch(AddException a)
            {
                Console.WriteLine(a.Message);
                Console.WriteLine(a.HelpLink);
            }
        }
    }
}
