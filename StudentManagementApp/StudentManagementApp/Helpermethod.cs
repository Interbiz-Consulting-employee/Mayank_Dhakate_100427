using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    static class StudentExtension
    {
        public static double GetAverage(this Student s)
        {
            int total = 0;

            foreach (int m in s.Marks)
            {
                total += m;
            }

            return (double)total / s.Marks.Count;
        }
    }
}
