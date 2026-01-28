namespace Linq

   
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;


    public  class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>() { 43,56,1,2,3,77,4,5,6,7,8,88,9};
           ArrayList mixed = new ArrayList() { 1,"mayank",'M',true,7,'k',"jhon"};
            //var double1= list.Select(n => n * 2).ToList();
            //foreach (var i in double1)
            //{
            //    Console.WriteLine(i);
            //}
            //var filtered = list.Where(n => n > 4);
            //foreach (var item in filtered)
            //{
            //    Console.WriteLine(item);


            //}
            //var integers = mixed.OfType<int>();
            //var strings= mixed.OfType<string>();
            //foreach (int i in integers) {
            //    Console.WriteLine("integer" +i);
            //}
            //foreach (var s in strings) {
            //    Console.WriteLine("Strins are"+s);
            //}
            //var order=list.OrderBy(x => x);
            //var desc =list.OrderByDescending(x => x);

            //foreach (var item in desc) {
            //    Console.WriteLine(item);
            //}

            //var order1=list.OrderBy(x => x%2).ThenBy(x=>x);
            //foreach (int x in order1) {
            //    Console.WriteLine(x);
            //}
            int add =list.Select(x => x).Sum();
            Console.WriteLine(add);
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Average());
            Console.WriteLine(list.Count);

            Console.ReadLine();
        }
    }
}
