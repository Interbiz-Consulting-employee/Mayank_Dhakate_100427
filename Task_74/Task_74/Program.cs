namespace Task_74
{
    internal class Program
    {

        public static int FindMissingDivisor(int n, int[] arr)
        {
            // Store given divisors for fast lookup
            HashSet<int> divisors = new HashSet<int>(arr);

            // Loop from 1 to sqrt(n)
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    int pair = n / i;

                    // Check first divisor
                    if (!divisors.Contains(i))
                        return i;

                    // Check paired divisor
                    if (!divisors.Contains(pair))
                        return pair;
                }
            }

            return -1; // Should never reach here (one divisor is guaranteed missing)
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingDivisor(100, new int[] { 1, 2, 4, 5, 10, 20, 50, 100 })); // 25
            Console.WriteLine(FindMissingDivisor(36, new int[] { 2, 3, 4, 6, 9, 12, 18, 36 }));     // 1
            Console.WriteLine(FindMissingDivisor(84, new int[] { 1, 2, 3, 4, 6, 7, 12, 14, 21, 84 })); // 28
        }
    }
}
