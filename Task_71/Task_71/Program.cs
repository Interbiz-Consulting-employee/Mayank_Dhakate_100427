namespace Task_71
{
    using System;
    public class Program
    {
        public static (int length, int start, int end) LongestZeroSumSubarray(int[] nums) 
            {

                int maxLength = 0;
                int startIndex = -1;
                int endIndex = -1;

                for (int i = 0; i < nums.Length; i++)
                {
                    int sum = 0;

                    for (int j = i; j < nums.Length; j++)
                    {
                        sum += nums[j];

                        if (sum == 0)
                        {
                            int length = j - i + 1;

                            if (length > maxLength)
                            {
                                maxLength = length;
                                startIndex = i;
                                endIndex = j;
                            }
                        }
                    }
                }

                return (maxLength, startIndex, endIndex);
            }

            static void Main()
            {
                //int[] nums = { 1, -1, 3, 2, -2, -3, 3 };
                //int[] nums = { 4, -2, -2, 2,-2,-4 };
                int[] nums = { 1,2,3};




            var result = LongestZeroSumSubarray(nums);

                if (result.length == 0)
                    Console.WriteLine("Length = 0");
                else
                    Console.WriteLine($"Length = {result.length}, Start = {result.start}, End = {result.end}");
            }
        }
    }



