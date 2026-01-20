namespace Anonymus_Method
{
    public delegate void mydelegate(string msg);
    public class Program
    {
        static void Main(string[] args)
        {
            mydelegate show = delegate(string msg) 
            {
                Console.WriteLine("Hi"+ msg);
            };
            show("mayank");
        }
    }
}
