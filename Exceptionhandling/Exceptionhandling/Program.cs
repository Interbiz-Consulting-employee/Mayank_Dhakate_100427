namespace Exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int a = 7;
            //    int b = 0;
            //    int c;
            //    c = a / b;
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //    Console.WriteLine(c);
            //try
            //{
            //    int a = 9;
            //    int b = 1;
            //    Console.WriteLine(a / b);
            //}
            //catch
            //{
            //    Console.WriteLine("Some error occurred");
            //}
            try
            {
                    int[] arr = { 1, 2, 3, 4, };
                   Console.WriteLine(arr[9]);
               
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index is invalid");
            }
            finally
            {
                Console.WriteLine("Run finally");
            }
        }
    }
}