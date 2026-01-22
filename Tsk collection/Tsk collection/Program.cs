using System.Collections;

namespace Tsk_collection
{
    public class Program
    {
        class Student
        {
            public int Id;
            public string Name;


            public ArrayList Marks = new ArrayList();
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Mayank";


            s1.Marks.Add(90);
            s1.Marks.Add(85);
            s1.Marks.Add(95);


            Console.WriteLine("Student Name: " + s1.Name);
            Console.WriteLine("Student Id: " + s1.Id);


            Console.WriteLine("Marks:");
            foreach (int mark in s1.Marks)
            {
                Console.WriteLine(mark);
            }

        }
    }
}
