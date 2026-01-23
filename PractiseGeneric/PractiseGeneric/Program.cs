namespace PractiseGeneric
{
    using System.Collections.Generic;
    using System.Globalization;

    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> num = new List<int>();
            //num.Add(1);
            //num.Add(2);
            //num.Add(3);
            //num.Remove(2);
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}
            //Dictionary<int, string> student = new Dictionary<int, string>();
            //student.Add(1, "Mayank");
            //student.Add(3, "rahul");
            //student.Add(2, "amit");
            //student.Add(4, "sagar");
            //student.Add(5, "harsh");
            //foreach (var item in student)
            //{
            //    Console.WriteLine(item.Key + ":" + item.Value);
            //}
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Clear();
            
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
