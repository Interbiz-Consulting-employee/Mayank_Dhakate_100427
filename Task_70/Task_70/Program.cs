namespace Task_70
{
    public class Program
    {
        public static (int length, int start) FindLongest(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return (0, 0);

            HashSet<int> set = new HashSet<int>(nums);

            int maxLength = 0;
            int bestStart = int.MaxValue;

            foreach (int num in set)
            {
                
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                  
                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }

             
                    if (currentLength > maxLength ||
                       (currentLength == maxLength && num < bestStart))
                    {
                        maxLength = currentLength;
                        bestStart = num;
                    }
                }
            }

            return (maxLength, bestStart);
        }
        static void Main(string[] args)
        {
            var result1 = FindLongest(new int[] { 100, 4, 200, 1, 3, 2 });
            Console.WriteLine($"Length = {result1.length}, Start = {result1.start}");

            var result2 = FindLongest(new int[] { 1, 2, 2, 3 });
            Console.WriteLine($"Length = {result2.length}, Start = {result2.start}");

            var result3 = FindLongest(new int[] { 0, -1, 1, 2, -2, -3 });
            Console.WriteLine($"Length = {result3.length}, Start = {result3.start}");
        }
    }
}
