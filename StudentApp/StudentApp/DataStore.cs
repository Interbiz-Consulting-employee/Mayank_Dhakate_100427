using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentApp
{
    public static class DataStore
    {
        public static List<Student> Students = new List<Student>();

        public static void ShowClassesEvery10Seconds()
        {
            while (true)
            {
                Console.WriteLine("\n--- Student Classes ---");
                foreach (Student s in Students)
                    Console.WriteLine($"{s.FirstName} : Class {s.Class}");

                Thread.Sleep(10000);
            }
        }
    }
}
