namespace Task_Linq2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Mayank", Department = "IT", Salary = 50000 },
                new Employee { Id = 2, Name = "Rahul", Department = "HR", Salary = 40000 },
                new Employee { Id = 3, Name = "Amit", Department = "IT", Salary = 60000 },
                new Employee { Id = 4, Name = "Neha", Department = "Sales", Salary = 45000 }
            };

            
            IEnumerable<Employee> ItEmployees =
                employees.Where(e => e.Department == "IT");

            Employee firstITEmployee = ItEmployees.First();

     
            Console.WriteLine("First IT Employee:");
            Console.WriteLine($"Id: {firstITEmployee.Id}");
            Console.WriteLine($"Name: {firstITEmployee.Name}");
        }
    }
}
