using System;
using System.Collections.Generic;

namespace StudentApp
{
    public static class FilterExtension
    {
        public static void FilterBySubject(this List<Student> students, SubjectType subject)
        {
            foreach (Student s in students)
            {
                if (s.Subjects.Contains(subject))
                    s.PrintFullDetails();
            }
        }

        public static void FilterByAddress(this List<Student> students, string address)
        {
            foreach (Student s in students)
            {
                if (!string.IsNullOrEmpty(s.Address) &&
                    s.Address.ToLower().Contains(address.ToLower()))
                {
                    s.PrintFullDetails();
                }
            }
        }

        public static void FilterByHobby(this List<Student> students, string hobby)
        {
            foreach (Student s in students)
            {
                foreach (string h in s.Hobbies)
                {
                    if (h.Equals(hobby, StringComparison.OrdinalIgnoreCase))
                    {
                        s.PrintFullDetails();
                        break;
                    }
                }
            }
        }

        public static void FilterByDateRange(this List<Student> students, DateTime from, DateTime to)
        {
            foreach (Student s in students)
            {
                if (s.AddedDate >= from && s.AddedDate <= to)
                    s.PrintFullDetails();
            }
        }
        public static void FilterByFirstName(this List<Student> students, string firstName)
        {
            foreach (Student s in students)
            {
                if (!string.IsNullOrEmpty(s.FirstName) &&
                    s.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    s.PrintFullDetails();
                }
            }
        }
        public static void FilterByMiddleName(this List<Student> students, string middleName)
        {
            foreach (Student s in students)
            {
                if (!string.IsNullOrEmpty(s.MiddleName) &&
                    s.MiddleName.Equals(middleName, StringComparison.OrdinalIgnoreCase))
                {
                    s.PrintFullDetails();
                }
            }
        }
        public static void FilterByLastName(this List<Student> students, string lastName)
        {
            foreach (Student s in students)
            {
                if (!string.IsNullOrEmpty(s.LastName) &&
                    s.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    s.PrintFullDetails();
                }
            }
        }
        public static void FilterByClass(this List<Student> students, int classNo)
        {
            foreach (Student s in students)
            {
                if (s.Class == classNo)
                {
                    s.PrintFullDetails();
                }
            }
        }
    }
}
