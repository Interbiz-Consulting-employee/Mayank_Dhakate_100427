using System.Collections.Generic;

namespace Task_Collection_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Add
            dict.Add(1, "One");
            dict.Add(3, "Three");
            dict.Add(4, "four");
            dict[2] = "Two";

            // Remove
            //dict.Remove(1);
            // dict.Clear(); // removes all
            

            // Search
            Console.WriteLine(dict.ContainsKey(2));
            Console.WriteLine(dict.ContainsValue("Two"));

            // Access
            string value = dict[2];
            Console.WriteLine(value);
          

            // Iterate
            foreach (var item in dict)
                Console.WriteLine(item.Key+":"+item.Value);
        }
    }
}
