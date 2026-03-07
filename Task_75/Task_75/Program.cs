namespace Task_75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "aab";
            //string s = "racecar";
            string s = "abccbc";
            MinPalindromePartition(s);
        }


        static bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;

                start++;
                end--;
            }
            return true;
        }

        static void MinPalindromePartition(string s)
        {
            int n = s.Length;

            int[] cuts = new int[n];
            int[] prev = new int[n];

            for (int i = 0; i < n; i++)
            {
                cuts[i] = i;
                prev[i] = -1;

                for (int j = 0; j <= i; j++)
                {
                    if (IsPalindrome(s, j, i))
                    {
                        if (j == 0)
                        {
                            cuts[i] = 0;
                            prev[i] = -1;
                        }
                        else if (cuts[j - 1] + 1 < cuts[i])
                        {
                            cuts[i] = cuts[j - 1] + 1;
                            prev[i] = j - 1;
                        }
                    }
                }
            }

            Console.WriteLine("Cuts = " + cuts[n - 1]);

            List<string> result = new List<string>();
            int index = n - 1;

            while (index >= 0)
            {
                int start = prev[index] + 1;
                result.Insert(0, s.Substring(start, index - start + 1));
                index = prev[index];
            }

            Console.WriteLine("Partition:");
            foreach (var part in result)
                Console.WriteLine(part);
        }

    }
}
