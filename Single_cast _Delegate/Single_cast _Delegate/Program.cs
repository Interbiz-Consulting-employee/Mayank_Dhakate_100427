namespace Single_cast__Delegate
{
    public delegate void Single();
    public class light()
    {
        public static void lighton()
        {
            Console.WriteLine("Light is on");
        }
    }
    public class Program
    {
        
        static void Main(string[] args)
        {
            light l = new light();
            Single s = light.lighton;
            s();
        }
    }
}
