using System;
using System.Collections.Generic;

namespace Task_82
{
    internal class Program
    {
        static bool WordBreak(string s, List<string> dictionary)
        {
            int n = s.Length;

            bool[] dp = new bool[n + 1];

            dp[0] = true; // empty string

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] == true)
                    {
                        string part = s.Substring(j, i - j);

                        if (dictionary.Contains(part))
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                }
            }

            return dp[n];
        }

        static void Main(string[] args)
        {
            List<string> dict1 = new List<string> { "i", "like", "gfg" };
            Console.WriteLine(WordBreak("ilike", dict1)); // true

            List<string> dict2 = new List<string> { "i", "like", "man", "india", "gfg" };
            Console.WriteLine(WordBreak("ilikegfg", dict2)); // true

            List<string> dict3 = new List<string> { "i", "like", "gfg" };
            Console.WriteLine(WordBreak("ilikemangoes", dict3)); // false
        }
    }
}