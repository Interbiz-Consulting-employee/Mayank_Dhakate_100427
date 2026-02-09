using System;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace StudentApp
{
    public class Student
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public int Age;
        public int RollNo;
        public int Class;
        public string Address;

        public List<SubjectType> Subjects = new List<SubjectType>();
        public List<int> Marks = new List<int>();
        public List<string> Hobbies = new List<string>();

        public DateTime AddedDate;

        public double GetAverage()
        {
            if (Marks.Count == 0)
                return 0;

            double total = 0;

            foreach (int m in Marks)
                total += m;

            return total / Marks.Count;
        }
    }
}