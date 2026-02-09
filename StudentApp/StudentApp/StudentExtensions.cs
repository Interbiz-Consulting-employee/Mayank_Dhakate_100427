using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentApp
{
    public static class StudentExtensions
    {
        public static void PrintFullDetails(this Student s)
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine($"Name: {s.FirstName} {s.MiddleName} {s.LastName}");
            Console.WriteLine($"Age: {s.Age}");
            Console.WriteLine($"Roll No: {s.RollNo}");
            Console.WriteLine($"Class: {s.Class}");
            Console.WriteLine($"Address: {s.Address}");
            Console.WriteLine($"Added Date: {s.AddedDate}");

            Console.Write("Subjects & Marks: ");
            for (int i = 0; i < s.Subjects.Count; i++)
                Console.Write($"\n{s.Subjects[i]}:({s.Marks[i]}) ");

            Console.Write("\nHobbies: ");
            foreach (string h in s.Hobbies)
                Console.Write(h+",");

            //Console.WriteLine("\n----------------------------");
        }
        static bool ReadYesNo(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                string input = Console.ReadLine().ToLower();

                if (input == "y") return true;
                if (input == "n") return false;

                Console.WriteLine(" Please enter only 'y' or 'n'");
            }
        }
   

    }
}
