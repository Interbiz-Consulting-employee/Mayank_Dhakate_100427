namespace Task_76
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfTwo(1));   // true
            Console.WriteLine(IsPowerOfTwo(16));  // true
            Console.WriteLine(IsPowerOfTwo(3));   // false
            Console.WriteLine(IsPowerOfTwo(-8));  // false
            Console.WriteLine(IsPowerOfTwo(0));   // false
            Console.WriteLine(IsPowerOfTwo(230)); //false
        }
        static bool IsPowerOfTwo(int n)
        {
            
            if (n <= 0)
                return false;

            // Loop method: keep dividing by 2
            while (n % 2 == 0)
            {
                n /= 2;  
            }

            // If we end with 1, it's a power of two
            return n == 1;
        }
    }
}
