using System;
using System.Collections.Generic;
using System.Threading;

namespace StudentManagementApp
{
    public class DataStore
    {
        public static List<Student> students = new List<Student>();
        public static void showClassEvery10sec()
        {
            while (true)
            {
                Console.WriteLine("\n------------Classes------------");
                foreach (Student s in students)
                {
                    Console.WriteLine("Class:" + s.Class);
                }
                Thread.Sleep(10000);
            }
        }
    }
}
