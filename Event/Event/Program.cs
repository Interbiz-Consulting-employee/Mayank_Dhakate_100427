namespace Event
{
    public delegate void SimpleDelegate();
    public class Program
    {
        public static event SimpleDelegate OnEvent;
        static void Main(string[] args)
        {
            OnEvent += Eventhandler;
            Console.WriteLine("Triggering event......");
            OnEvent?.Invoke();
        }
        static void Eventhandler()
        {
            Console.WriteLine("Event Handeled");
        }
    }
}
