using System.Text.RegularExpressions;

namespace Task_Regex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password ");
            }
        }
    }
}