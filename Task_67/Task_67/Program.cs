namespace Task_67
{
    public class Program
    {
        static int Missingnumber(int[] nums)
        {
            int n=nums.Length;
            int expectedSum=n*(n+1)/2;
            int actualSum = 0;
            for (int i = 0; i < n; i++)
            {
                actualSum += nums[i];
            }
            return expectedSum - actualSum;
        }
        static void Main(string[] args)
        {
            int[] nums = { 0,1 };
            int result = Missingnumber(nums);
            Console.WriteLine("Missing number is"+ " "+ result);
            
        }
    }
}
