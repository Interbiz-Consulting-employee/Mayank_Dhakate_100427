namespace StudentManagementApp
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    public class Program
    {
        static void AddStudent()
        {
            try
            {
                Student s=new Student();
                Console.Write("Name:");
                s.FirstName = Console.ReadLine();
            }
            catch(Exception ex) {
                Console.WriteLine("Error:"+ex.Message);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--------**MAIN MENU**-----------");
                Console.WriteLine("1: Add Student");
                Console.WriteLine("2:Show All");
                Console.WriteLine("3:Age 15-25");
                Console.WriteLine("4:Topper");
                Console.WriteLine("5:Show Classes of students");
                Console.WriteLine("0:Exit");
                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddStudent();break;
                    case 2: ShowAll(); break;
                    case 3: AgeFilter(); break;
                    case 4: FindTopper(); break;
                    case 5: ShowClass(); break;
                    case 0: return; 


                }

            }


        }
    }
}
