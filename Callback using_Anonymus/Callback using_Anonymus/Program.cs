namespace Callback_using_Anonymus
{
    public delegate void Mydelegate();
    public class Program
    {
        static void Main(string[] args)
        {
            Mydelegate del = Orderdone;
            Processing(del);
            
        }
        static void Processing(Mydelegate callback)
        {
            Console.WriteLine("Order is in process.........");
            callback();
        }
        static void Orderdone()
        {
            Console.WriteLine("order is ready!!");
        }
    }
}
