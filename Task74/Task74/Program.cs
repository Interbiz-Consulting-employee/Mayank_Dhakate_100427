namespace Task74
{
    internal class Program
    {
        public static long FindMissingDivisor(long n, int[] arr)
        {
            long totalSum = 0;

            // Step 1: Find sum of all divisors of n
            for (long i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    long pair = n / i;

                    totalSum += i;

                    if (i != pair)
                        totalSum += pair;
                }
            }

            // Step 2: Sum of given array
            long arrSum = 0;
            foreach (int num in arr)
                arrSum += num;

            // Step 3: Missing divisor
            return totalSum - arrSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingDivisor(100, new int[] { 1, 2, 4, 5, 10, 20, 50, 100 })); 
            Console.WriteLine(FindMissingDivisor(36, new int[] { 2, 3, 4, 6, 9, 12, 18, 36 }));
            

        }
    }
}
