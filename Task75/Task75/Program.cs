namespace Task75
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "abccbc";
            var result = MinCutPalindrome(s);
            Console.WriteLine("Cuts = " + result.Item1);
            Console.WriteLine("Partition = [" + string.Join(", ", result.Item2) + "]");
        }


        static Tuple<int, List<string>> MinCutPalindrome(string s)
        {
            int n = s.Length;
            bool[,] isPal = new bool[n, n];

            // Step 1: Palindrome table using loops
            for (int length = 1; length <= n; length++)
            {
                for (int i = 0; i <= n - length; i++)
                {
                    int j = i + length - 1;
                    if (length == 1)
                        isPal[i, j] = true;
                    else if (length == 2)
                        isPal[i, j] = s[i] == s[j];
                    else
                        isPal[i, j] = (s[i] == s[j]) && isPal[i + 1, j - 1];
                }
            }

            int[] dp = new int[n]; // min cuts
            int[] cutPos = new int[n]; // last cut index

            for (int i = 0; i < n; i++)
            {
                if (isPal[0, i])
                {
                    dp[i] = 0;
                    cutPos[i] = -1;
                }
                else
                {
                    dp[i] = n; // max possible cuts
                    for (int j = 0; j < i; j++)
                    {
                        if (isPal[j + 1, i] && dp[j] + 1 < dp[i])
                        {
                            dp[i] = dp[j] + 1;
                            cutPos[i] = j;
                        }
                    }
                }
            }

            // Step 2: Build partition using a collection (List) + tuple logic
            List<string> partition = new List<string>();
            int idx = n - 1;
            while (idx >= 0)
            {
                int start = cutPos[idx] + 1;
                partition.Insert(0, s.Substring(start, idx - start + 1));
                idx = cutPos[idx];
            }

            return Tuple.Create(dp[n - 1], partition);
        }

    }
}
