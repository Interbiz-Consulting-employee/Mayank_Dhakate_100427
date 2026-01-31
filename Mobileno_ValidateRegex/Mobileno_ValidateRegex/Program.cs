namespace Mobileno_ValidateRegex
{
    using System.Text.RegularExpressions;
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a valid mobile with country code:");
            string mobileno = Console.ReadLine();
            string pattern = @"^\+\d{1,3}\d{10}$";
            if(Regex.IsMatch(mobileno, pattern))
            {
                Console.WriteLine("Mobile number validate  successfully");
            }
            else
            {
                Console.WriteLine("Invalid mobile number");
            }
        }
    }
}
