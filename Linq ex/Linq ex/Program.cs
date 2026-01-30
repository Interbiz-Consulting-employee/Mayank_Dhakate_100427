namespace Linq_ex
{
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] num= {1,2,32,4,5,8,77,44};
            //var query = num.Where(n => n > 2).ToList();
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();
            //var query = from n in num
            //where n > 2
            //select n;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            //var query = num.OrderBy(n => n);
            //foreach (int i in query)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //var query = num.Where(n => n > 5).Sum();
            //Console.WriteLine(query);
            var query1 = num.Where(n => n % 2 == 0).OrderBy(n=>n);

            Console.WriteLine(query1);
            Console.ReadLine();
        }
    }
}
