namespace ExampleDelegate
{
    public delegate void notify(string message);
    public class Program
    {
        public class doorbell
        {
            public event notify OnRing;
            public void Press()
            {
                Console.WriteLine("Dorbell Pressed");
                OnRing?.Invoke("Some one is at door");
            }
        }
        public class Device
        {
            public void Mobile(string message)
            {
                Console.WriteLine("Mobile message"+message);

            }
            public void Tv(string message)
            {
                Console.WriteLine("Tv message" + message);
            }
            public void Alarm(string message)
            {
                Console.WriteLine("Alarm message" + message);
            }
        }

        static void Main(string[] args)
        {
            doorbell d=new doorbell();
            Device d1=new Device();
            d.OnRing += d1.Mobile;
            d.OnRing += d1.Tv;

            d.Press();
        }
    }
}
