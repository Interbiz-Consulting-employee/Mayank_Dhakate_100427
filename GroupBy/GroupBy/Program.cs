namespace GroupBy
{
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Mayank", Salary = 50000 },
                new Employee { Id = 2, Name = "Rahul", Salary = 45000 },
                new Employee { Id = 3, Name = "Amit", Salary = 60000 },
                new Employee { Id = 4, Name = "Neha", Salary = 55000 },
                new Employee { Id = 5, Name = "Pooja", Salary = 48000 }
            };
            var query= from e in employees
                       where e.Salary>20000
                       select e;
            foreach(var item in employees)
            {
                Console.WriteLine(item);
            }
            var methodsyn= employees.Where(e=>e.Salary;
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
