namespace EmployeeLinq
{
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
            new Employee() { Id = 1, Name = "Mayank", Salary = 11000 },
            new Employee() { Id = 2, Name = "Manish", Salary = 210000 } ,
            new Employee() { Id = 3, Name = "Mohit", Salary = 160000 },
            new Employee() { Id = 4, Name = "Arun", Salary = 19000 },
            new Employee() { Id = 5, Name = "Saurabh", Salary = 21000 },
            new Employee() { Id = 6, Name = "Vaibhav", Salary = 10000 },
};
            var highsalary = from e in employees
                             where e.Salary > 20000
                             select e;
            foreach (var item in highsalary)
            {
                Console.WriteLine($"{item.Id} ,{item.Name} ,{item.Salary}");
            }
            Console.ReadLine();
            var methodhigh = employees.Where(e => e.Salary > 20000);
            foreach (var item in methodhigh)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Salary}");
            }
            Console.ReadLine();
            var samename = from e in employees
                           where e.Name.StartsWith("M")
                           select e.Name;

            var samemethod = employees.Where(e => e.Name.StartsWith("M")).Select(e => e.Name);
            foreach (var item in samemethod)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            var sortedsalary = employees.OrderByDescending(e => e.Salary);
            foreach (var item in sortedsalary)
            {
                Console.WriteLine($"{item.Name},{item.Salary}");
            }
            Console.ReadLine();
            var querysort = from e in employees
                            where e.Salary > 20000
                            orderby e.Salary descending
                            select e;
            foreach (var item in querysort)
            {
                Console.WriteLine(item.Name + item.Salary);
            }
            Console.ReadLine();
            //IEnumerable<Employee> highSalary = employees.Where(e => e.Salary > 20000);

            //Console.WriteLine("IEnumerable Example:");
            //foreach (var e in highSalary)
            //{
            //    Console.WriteLine($"{e.Name} - {e.Salary}");
            //}
            //Console.ReadLine();
        }
    
    }
}
