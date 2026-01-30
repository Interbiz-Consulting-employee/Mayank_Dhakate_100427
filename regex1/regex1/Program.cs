namespace regex1
{
    using System.Text.RegularExpressions;
public class Program
    {
        static void Main(string[] args)
        {
            //string email = "mayank@outlook.com";
            //string pattern1 = @"^[+0-9]+\d{10}$";
            //string mobileno = "917587321893";
            string password = "Mayank@9";
            string pattern2 = @"^A-Z+a-z+[@#*%]+0-9$";
            //string pattern = @"^[a-zA-Z0-9.%+-]+@[a-zA-z]+\.[a-zA-z]{2,}$";
            bool result =Regex.IsMatch(password, pattern2);
            if (result)
            {
                Console.WriteLine("Vaild");
            }
            else
            {
                Console.WriteLine("not valid");
            }
            Console.ReadLine();
        }
    }
}
