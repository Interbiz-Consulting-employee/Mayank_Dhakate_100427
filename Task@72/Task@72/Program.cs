namespace Task_72
{
    public class Program
    {
        public static int MinEatingSpeed(int[] nums, int h)
        {
            int max = 0;

            // Find maximum pile
            foreach (int num in nums)
            {
                if (num > max)
                    max = num;
            }

            // Try every possible speed from 1 to max
            for (int k = 1; k <= max; k++)
            {
                long totalHours = 0;

                foreach (int num in nums)
                {

                    totalHours += (num + k - 1) / k;
                }

                if (totalHours <= h)
                    return k; // first valid (minimum) speed
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of piles (n): ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("Enter number of bananas in each pile (space separated):");
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            Console.Write("Enter total hours (h): ");
            int h = int.Parse(Console.ReadLine());

            int result = MinEatingSpeed(nums, h);

            Console.WriteLine("Minimum eating speed: " + result);
        }
    }
}
