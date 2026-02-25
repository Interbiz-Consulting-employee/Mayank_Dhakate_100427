namespace Task_73
{
    public class Program
    {
        public int ClimbStairs(int n)
        {
            // Using 2 variables to store previous two steps
            int a = 1, b = 1;
            for (int i = 0; i < n - 1; i++)
                b = a + (a = b);
            return b;
        }
        static void Main(string[] args)
        {
            Program sol = new Program();

            Console.Write("Enter number of steps (n): ");
            int n = int.Parse(Console.ReadLine());

            int ways = sol.ClimbStairs(n);
            Console.WriteLine($"Number of distinct ways to climb {n} steps: {ways}");
        }
    }
}
