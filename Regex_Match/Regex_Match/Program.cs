using System.Text.RegularExpressions;

namespace Regex_Match
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string text = "Marks: 45, 67, 89";

                
                Match firstMatch = Regex.Match(text, @"\d+");
                Console.WriteLine("Using Match (first only): " + firstMatch.Value);

                
                MatchCollection allMatches = Regex.Matches(text, @"\d+");
                Console.WriteLine("Using Matches (all matches):");
                foreach (Match m in allMatches)
                {
                    Console.WriteLine(m.Value);
                }
                Console.ReadLine();
            }
        }
    }
}
