namespace Multi_cast_delegate
{
    public delegate void MultiDelegate();
    
    public class Program
    {
        public class Device
        {
            public  void tv()
            {
                Console.WriteLine("Tv is on");
            }
            public void radio()
            {
                Console.WriteLine("radio is on");
            }
            public void phone()
            {
                Console.WriteLine("phone is on");
            }
        }
        static void Main(string[] args)
        {
            Device d= new Device();
            MultiDelegate m = d.tv;
            m += d.phone;
            m += d.radio;
            m -= d.phone;
            m();
        }
    }
}
