namespace BaseMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 9;
                int y = 4;
                if (x % 2 == 0)
                {
                    Console.WriteLine(" first no is even");
                    
                }
                else
                {
                    throw new OddException("Custom error");
                }
                

            }
            catch (OddException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.HelpLink);
            }
        }
    }
}
