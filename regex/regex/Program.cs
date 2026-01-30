namespace regex
{
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Channels;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4 };
            string mobileno = "7583221893";
            string reg = @"^\d{10}$";
            bool result= Regex.IsMatch(mobileno, reg);  
            if (result)
            {
                Console.WriteLine("Mobile no is validate successfully");
            }
            else
            {
                
                    Console.WriteLine("not validate");
                
            }
            var query = num.Where(x => x > 1).Sum();
            Console.WriteLine(query);
            Console.ReadLine();
        }
        
       
    }
}
