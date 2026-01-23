namespace Generic1
{
    public class Program
    {
        
        public static bool Equal<T>(T a,T b)
        {
            return a.Equals(b);
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(Equal<int>(2, 2));
            Console.WriteLine(Equal<char>('A','C'));
        }
    }
}
