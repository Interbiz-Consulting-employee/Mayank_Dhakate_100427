namespace Task_81
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 1, 1, 3, 2 };
            int[] nums1 = { 1, 2, 1, 1, 3, 2, 2 };

            List<int> result = MajorityElement(nums1);

            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }

        static List<int> MajorityElement(int[] nums)
        {
            List<int> result = new List<int>();
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int count = 0;

                // count frequency of nums[i]
                for (int j = 0; j < n; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }

                // check if greater than n/3
                if (count > n / 3)
                {
                    // avoid duplicates in result
                    if (!result.Contains(nums[i]))
                    {
                        result.Add(nums[i]);
                    }
                }
            }

            return result;
        }
    }
}
