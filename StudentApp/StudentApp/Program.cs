namespace StudentApp

{
    public delegate bool StudentFilter(Student s);
    public class Program
    {
        static int ReadInt(string msg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(" Invalid number, try again.");
                }
            }
        }
        static int ReadIntInRange(string msg, int min, int max)
        {
            while (true)
            {
                int value = ReadInt(msg);
                if (value >= min && value <= max)
                    return value;

                Console.WriteLine($" Enter value between {min} and {max}");
            }
        }
        static bool IsDuplicateRoll(int roll)
        {
            foreach (Student s in DataStore.Students)
                if (s.RollNo == roll) return true;

            return false;
        }
        static bool BackOption()
        {
            Console.WriteLine();
            Console.WriteLine("10. Back to Main Menu");
            Console.WriteLine("0. Exit");

            while (true)
            {
                int choice = ReadInt("Enter choice: ");

                if (choice == 10)
                    return true;   // go back

                if (choice == 0)
                    Environment.Exit(0);

                Console.WriteLine("Invalid choice. Press 10 or 0.");
            }
        }

        static void AddStudent()
        {
            try
            {
                Student s = new Student();

                Console.Write("First Name: ");
                s.FirstName = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(s.FirstName) || !AllLetters(s.FirstName))
                {
                    Console.WriteLine("Error: First Name is mandatory and should contain only letters.");
                    Console.Write("First Name: ");
                    s.FirstName = Console.ReadLine();
                }


                Console.Write("Middle Name: ");
                s.MiddleName = Console.ReadLine();

                Console.Write("Last Name: ");
                s.LastName = Console.ReadLine();

                s.Age = ReadIntInRange("Age (5-100): ", 5, 100);

                while (true)
                {
                    s.RollNo = ReadInt("Roll No: ");
                    if (!IsDuplicateRoll(s.RollNo)) break;
                    Console.WriteLine("Roll No already exists.");
                }

                s.Class = ReadIntInRange("Class (1-12): ", 1, 12);

                Console.Write("Address: ");
                s.Address = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(s.Address))
                {
                    Console.WriteLine("Error: Address cannot be empty.");
                    Console.Write("Address: ");
                    s.Address = Console.ReadLine();
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



                foreach (SubjectType sub in Enum.GetValues(typeof(SubjectType)))
                {

                    bool addSubject = ReadYesNo($"Add {sub}? (y/n): ");

                    if (addSubject)
                    {
                        s.Subjects.Add(sub);
                        int marks = ReadIntInRange($"Marks for {sub} (0-100): ", 0, 100);
                        s.Marks.Add(marks);
                    }

                }

                int hobbyCount = ReadIntInRange("Hobbies count (1-7): ", 1, 7);

                for (int i = 0; i < hobbyCount; i++)
                {
                    while (true) // repeat until valid input
                    {
                        Console.Write($"Hobby {i + 1}: ");
                        string hobby = Console.ReadLine().Trim();

                        if (string.IsNullOrWhiteSpace(hobby))
                        {
                            Console.WriteLine("Error: Hobby cannot be empty.");
                            continue; // ask again
                        }

                        if (!AllLetters(hobby))
                        {
                            Console.WriteLine("Error: Hobby should contain letters only.");
                            continue; // ask again
                        }

                        s.Hobbies.Add(hobby); // valid
                        break;
                    }
                }


                s.AddedDate = DateTime.Now;
            
                DataStore.Students.Add(s);

                Console.WriteLine(" Student added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error: " + ex.Message);
            }
        }
        static void ShowAll()
        {
            if (DataStore.Students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student s in DataStore.Students)
                s.PrintFullDetails();
        }
        static void FilterStudents(StudentFilter filter)
        {
            foreach (Student s in DataStore.Students)
                if (filter(s))
                    s.PrintFullDetails();
        }

        static void FindTopper()
        {
            if (DataStore.Students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Student topper = null;
            double maxAvg = 0;

            foreach (Student s in DataStore.Students)
            {
                //  PASS check
                bool isPass = true;
                foreach (int m in s.Marks)
                {
                    if (m <= 33)
                    {
                        isPass = false;
                        break;
                    }
                }

                if (!isPass) continue; 

                double avg = s.GetAverage();

                if (avg > maxAvg)
                {
                    maxAvg = avg;
                    topper = s;
                }
            }

            if (topper == null)
            {
                Console.WriteLine("No topper found (all students failed).");
                return;
            }

            topper.PrintFullDetails();
        }
        static void ShowClassesThread()
        {
            Thread t = new Thread(DataStore.ShowClassesEvery10Seconds);
            t.IsBackground = true;   
            t.Start();
            Console.WriteLine("Thread started. Press menu options normally.");
        }


        static void NthTopper()
        {
            int n = ReadInt("Enter N: ");

            double lastMax = double.MaxValue;
            Student nthTopper = null;

            for (int i = 1; i <= n; i++)
            {
                double currentMax = -1;
                Student currentTopper = null;

                foreach (Student s in DataStore.Students)
                {
                    // Skip fail students
                    if (!s.Marks.All(m => m > 33))
                        continue;

                    double avg = s.GetAverage();

                    if (avg < lastMax && avg > currentMax)
                    {
                        currentMax = avg;
                        currentTopper = s;
                    }
                }

                if (currentTopper == null)
                {
                    Console.WriteLine("Not enough passed students.");
                    return;
                }

                lastMax = currentMax;
                nthTopper = currentTopper;
            }

            Console.WriteLine("Nth Topper:");
            nthTopper.PrintFullDetails();
        }


        static void FilterMenu1()
            {
                try
                {
                    Console.WriteLine("\n--- FILTER MENU ---");
                    Console.WriteLine("1. By First Name");
                    Console.WriteLine("2. By Middle Name");
                    Console.WriteLine("3. By Last Name");
                    Console.WriteLine("4. By Class");
                    Console.WriteLine("5. By Subject");
                    Console.WriteLine("6. By Address");
                    Console.WriteLine("7. By Hobby");
                    Console.WriteLine("8. By Added Date Range");

                    int choice = ReadInt("Enter filter choice: ");

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter First Name: ");
                            DataStore.Students.FilterByFirstName(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("Enter Middle Name: ");
                            DataStore.Students.FilterByMiddleName(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("Enter Last Name: ");
                            DataStore.Students.FilterByLastName(Console.ReadLine());
                            break;

                        case 4:
                            int cls = ReadIntInRange("Enter Class (1-12): ", 1, 12);
                            DataStore.Students.FilterByClass(cls);
                            break;

                        case 5:
                            Console.WriteLine("Subjects:");
                            foreach (SubjectType s in Enum.GetValues(typeof(SubjectType)))
                                Console.WriteLine($"{(int)s}. {s}");

                            int subChoice = ReadInt("Choose subject: ");
                            if (Enum.IsDefined(typeof(SubjectType), subChoice))
                            {
                                DataStore.Students.FilterBySubject((SubjectType)subChoice);
                            }
                            else
                            {
                                Console.WriteLine("Invalid subject.");
                            }
                            break;

                        case 6:
                            Console.Write("Enter Address keyword: ");
                            DataStore.Students.FilterByAddress(Console.ReadLine());
                            break;

                        case 7:
                            Console.Write("Enter Hobby: ");
                            DataStore.Students.FilterByHobby(Console.ReadLine());
                            break;

                        case 8:
                            DateTime from, to;

                            Console.Write("From date (yyyy-mm-dd): ");
                            if (!DateTime.TryParse(Console.ReadLine(), out from))
                            {
                                Console.WriteLine("Invalid date.");
                                return;
                            }

                            Console.Write("To date (yyyy-mm-dd): ");
                            if (!DateTime.TryParse(Console.ReadLine(), out to))
                            {
                                Console.WriteLine("Invalid date.");
                                return;
                            }

                            DataStore.Students.FilterByDateRange(from, to);
                            break;

                        default:
                            Console.WriteLine("Invalid filter choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Error: " + ex.Message);
                }
            }
        static bool AllLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }
        static void AgeFilter()
            {
                if (DataStore.Students.Count == 0)
                {
                    Console.WriteLine("No students available.");
                    return;
                }

                bool found = false;

                foreach (Student s in DataStore.Students)
                {
                    if (s.Age >= 15 && s.Age <= 25)
                    {
                        s.PrintFullDetails();
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No students found between age 15 and 25.");
                }
            }

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\n--- MENU ---");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Show All Students");
                    Console.WriteLine("3. Students Age 15–25");
                    Console.WriteLine("4. Filter Students");
                    Console.WriteLine("5. Find Topper");
                    Console.WriteLine("6. Nth Topper Roll No");
                    Console.WriteLine("7. Show Classes Every 10 Seconds");
                    Console.WriteLine("0. Exit");

                    int choice = ReadInt("Enter choice: ");

                    switch (choice)
                    {
                        case 1: AddStudent(); break;
                        case 2: ShowAll(); break;
                        case 3: AgeFilter(); break;
                        case 4: FilterMenu1(); break;
                        case 5: FindTopper(); break;
                        case 6: NthTopper(); break;
                        case 7: ShowClassesThread(); break;
                        case 0: return;
                        default: Console.WriteLine(" Invalid choice."); break;
                    }
                }
            }
        }
    }

    

