namespace PractiseAnonymus
{
    public delegate void Mydelegate();
    public class Program
    {
        static void Main(string[] args)
        {
            Mydelegate del = delegate
            {
                orderdone();
            };
            Orderprocess(del);
            
        }
        static void Orderprocess(Mydelegate callback)
        {
            Console.WriteLine("order in process....");
            callback();
        }
        static void orderdone()
        {
            Console.WriteLine("Order is ready");
        }
    }
}
