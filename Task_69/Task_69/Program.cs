namespace Task_69
{
    public class Program
    {
        static void Main(string[] args)
        {
            String[] strs = { "flower", "flow", "flight" };
            //string[] strs = { "dog", "racecar", "car" };

            string result = LongestCommonPrefix(strs);
            Console.WriteLine(result);   
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            Array.Sort(strs);

            string first = strs[0];
            string last = strs[strs.Length - 1];

            int i = 0;
            while (i < first.Length && i < last.Length && first[i] == last[i])
            {
                i++;
            }

            return first.Substring(0, i);
        }
    }
}
