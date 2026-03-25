namespace Task_80
{
    public class Program
    {
        public static bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');

            // Condition 1: length must match
            if (pattern.Length != words.Length)
                return false;

            Dictionary<char, string> map1 = new Dictionary<char, string>();
            Dictionary<string, char> map2 = new Dictionary<string, char>();

            for (int i = 0; i < pattern.Length; i++)
            {
                char p = pattern[i];
                string word = words[i];

                // If pattern character already mapped
                if (map1.ContainsKey(p))
                {
                    if (map1[p] != word)
                        return false;
                }
                else
                {
                    map1[p] = word;
                }

                // If word already mapped
                if (map2.ContainsKey(word))
                {
                    if (map2[word] != p)
                        return false;
                }
                else
                {
                    map2[word] = p;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WordPattern("abba", "dog cat cat dog")); // true
            Console.WriteLine(WordPattern("abba", "dog cat cat fish")); // false
            Console.WriteLine(WordPattern("aaaa", "dog cat cat dog")); // false
        }
    }
}
