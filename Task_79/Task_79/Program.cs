namespace Task_79
{
    public class Program
    {
        static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] > nums[right])
                {
                  
                    left = mid + 1;
                }
                else
                {
                    
                    right = mid;
                }
            }

            return nums[left];
        }
        static void Main(string[] args)
        {
            //int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
           // int[] nums = [3, 4, 5, 1, 2];
            int[] nums = [11, 13, 15, 17];
            Console.WriteLine("Minimum: " + FindMin(nums));

        }

    }
}