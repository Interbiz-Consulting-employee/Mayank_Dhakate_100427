using System.Collections;

namespace Task_collection1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            int size = list.Count;
            Console.WriteLine(size);
            Student s1= new Student();
            s1.Name = "Mayank";
            s1.Id = 9;
            list.Add(s1 );
            Student s2 =(Student)list[3];
            Console.WriteLine("Name"+s2.Name);
           

        }
    }
}
