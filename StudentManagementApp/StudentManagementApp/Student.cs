using System;
using System.Collections.Generic;
using System.Threading;

namespace StudentManagementApp
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public int RollNo { get; set; }
        public int Class { get; set; }

        public string Address { get; set; }

        public List<string> Subjects { get; set; }
        public List<int> Marks { get; set; }

        public List<string> Hobbies { get; set; }

        public DateTime AddedDate { get; set; }

    }
}
