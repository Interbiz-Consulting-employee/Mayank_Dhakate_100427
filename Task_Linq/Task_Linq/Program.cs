namespace Task_Linq
{
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //var result = list.FirstOrDefault();
            //Console.WriteLine(result);
            ////var result1=list.First();
            ////Console.WriteLine(result1);

            List<string> employees = new List<string>
        {
            "Amit","Ravi","Neha","Pooja","Rahul",
            "Kiran","Sonal","Vijay","Ankit","Priya",
            "Deepak","Rohit","Sneha","Manoj","Kajal"
        };

            int pageNumber = 3;   // Which page you want
            int pageSize = 5;     // Records per page

            var result2 = employees
                         .Skip((pageNumber - 1) * pageSize)
                         .Take(pageSize);

            foreach (var emp in result2)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
