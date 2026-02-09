namespace StudentManagementApp
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
   public enum SubjectType
    {
        Math = 1,
        Physics,
        Chemistry,
        English,
        Computer,
        Biology
    }
    public class Program
    {
   
        static void AddStudent()
        {
            try
            {
                Student s=new Student();
                Console.Write("Name:");
                s.FirstName = Console.ReadLine();

                Console.Write("Age: ");
                s.Age=int.Parse(Console.ReadLine());

                Console.Write("Roll: ");
                s.RollNo=int.Parse(Console.ReadLine());

                Console.Write("Class: ");
                s.Class=int.Parse(Console.ReadLine());

                Console.Write("Enter Address: ");
                s.Address = Console.ReadLine();

                s.Subjects = new List<SubjectType>();
                s.Marks = new List<int>();

                foreach (SubjectType sub in Enum.GetValues(typeof(SubjectType)))
                {
                    Console.Write($"Add {sub}? (y/n): ");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        s.Subjects.Add(sub);
                        Console.Write($"Enter marks for {sub}: ");
                        s.Marks.Add(int.Parse(Console.ReadLine()));
                    }
                }

                s.Hobbies = new List<string>();

                int hobbyCount = 0;

                while (true)
                {
                    Console.Write("How many hobbies (1 to 7): ");
                    hobbyCount = int.Parse(Console.ReadLine());

                    if (hobbyCount >= 1 && hobbyCount <= 7)
                        break;

                    Console.WriteLine("Please enter between 1 and 7 only!");
                }

                for (int i = 0; i < hobbyCount; i++)
                {
                    Console.Write("Enter Hobby " + (i + 1) + ": ");
                    s.Hobbies.Add(Console.ReadLine());
                }



                s.AddedDate = DateTime.Now;

                DataStore.students.Add(s);
                Console.WriteLine("Student Added successfully");

            }
            catch(Exception ex) {
                Console.WriteLine("Error:"+ex.Message);
            }
        }
       
        static void ShowAll()
        {
            foreach (Student s in DataStore.students)
            {
                Console.WriteLine($"{s.FirstName}| Roll {s.RollNo}|Age{s.Age}");


            }
        }
        static void FindTopper()
        {
            Student topper = null;
            double max = 0;

            foreach (Student s in DataStore.students)
            {
                double avg = s.GetAverage();

                if (avg > max)
                {
                    max = avg;
                    topper = s;
                }
            }

            Console.WriteLine("Topper: " + topper.FirstName);
        }


        static void AgeFilter()
        {
            foreach (Student s in DataStore.students)
            {
                if (s.Age >= 15 && s.Age <= 25)
                {
                    Console.WriteLine(s.FirstName);
                }
            }
        }
        static void ShowClass()
        {
            Thread t = new Thread(DataStore.showClassEvery10sec);
            t.Start();

            Console.WriteLine("Thread Started");
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
