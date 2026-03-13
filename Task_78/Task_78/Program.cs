namespace Task_78
{
    public class Program
    {
        static int FindEquilibriumIndex(int[] arr)
        {
            // Loop through each index of the array
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;  // Initialize left sum as 0
                int rightSum = 0; // Initialize right sum as 0

                // Calculate left sum by adding elements before the current index
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                // Calculate right sum by adding elements after the current index
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                // If left sum equals right sum, return the current index
                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            // If no equilibrium index is found, return -1
            return -1;
        }

        static void Main(string[] args)
        {
          
            int[] arr1 = { 1, 3, 5, 2, 2 };
            int[] arr2 = { 1, 2, 3 };
            int[] arr3 = { 2, 4, 2 };
            int[] arr4 = { 0, -3, 5, -4, -2, 3, 1, 0 };

            
            Console.WriteLine(FindEquilibriumIndex(arr1)); // Output: 2
            Console.WriteLine(FindEquilibriumIndex(arr2)); // Output: -1
            Console.WriteLine(FindEquilibriumIndex(arr3)); // Output: 1
            Console.WriteLine(FindEquilibriumIndex(arr4)); // Output: 0
        }
    }
}
