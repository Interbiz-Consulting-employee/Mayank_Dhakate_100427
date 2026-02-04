namespace Linq_Practise
{
    using System.Collections.Generic;
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,Name="Mayank",Department="IT",Salary=20000},
                new Employee{Id=2,Name="Atul",Department="Marketing",Salary=10000},
                new Employee{Id=3,Name="Rahul",Department="IT",Salary=25000},
                new Employee{Id=4,Name="Manish",Department="IT",Salary=22000},
                new Employee{Id=5,Name="Tom",Department="Finance",Salary=30000},
                new Employee{Id=6,Name="Harish",Department="IT",Salary=55000},
                new Employee{Id=7,Name="Farhan",Department="HR",Salary=20200},
                new Employee{Id=8,Name="Satish",Department="Finance",Salary=120000},

            };
            IEnumerable<Employee> employees1 = employees.OrderBy(e=>e.Salary).Select(e=>e);
            foreach(var item in employees1)
            {
                Console.WriteLine(item.Name+item.Salary);

            }


            //Select using query and method syntax
            // var query =from e in employees
            //            select e;
            //Console.WriteLine("detail of employee using query syntax");

            //foreach(var item in query)
            //{
            //    Console.WriteLine($"{item.Name},{item.Id},{item.Department},{item.Salary}");
            //}
            //Console.WriteLine("=======================");
            //var method = employees.Select(e => e);
            //Console.WriteLine("detail of employee using method syntax");
            //foreach (var item1 in method)
            //{
            //    Console.WriteLine($"{item1.Id},{item1.Department}");
            //}

            //Console.WriteLine("=======================");
            //Console.WriteLine("Detail of employee salary more than 30000 with query syntax");
            //var filterquery=from e in employees
            //                where e.Salary>30000
            //                select e;
            //foreach (var item2 in filterquery)
            //{
            //    Console.WriteLine($"{item2.Name}-{item2.Department}-{item2.Salary}");
            //}
            //Console.WriteLine("Detail of employee salary more than 30000 with Method syntax");
            //var methodfilter = employees.Where(e => e.Salary > 30000).Select(e=>e);
            //foreach( var item3 in methodfilter)
            //{
            //    Console.WriteLine($"{item3.Id}-{item3.Name}-{item3.Salary}");
            //}
            //Console.WriteLine("======================================");
            //Console.WriteLine("order by ascending and descending by salary with query syntax");
            //var order=from e in employees
            //          orderby e.Salary
            //          select e;
            //foreach (var item4 in order)
            //{
            //    Console.WriteLine($"{item4.Id}-{item4.Salary}-{item4.Name}");
            //}
            //Console.WriteLine("order by ascending and descending by salary with Method syntax");
            //var ordermethod= employees.OrderBy(e=>e.Salary).Select(e=>e);
            //foreach(var item5 in ordermethod)
            //{
            //    Console.WriteLine($"{item5.Id}:{item5.Salary}:{item5.Name}");
            //}
            //Console.WriteLine("===========================================");
            //Console.WriteLine("Order by  salary where salary more 30000 by query syntax");
            //var orderwherequery = from e in employees
            //                      where e.Salary > 30000
            //                      orderby e.Salary
            //                      select e;
            //foreach(var item6 in orderwherequery)
            //{
            //    Console.WriteLine($"{item6.Name} {item6.Salary}");
            //}
            //Console.WriteLine("Order by  salary where salary more 30000 by method syntax");
            //var orderwheremethod = employees.Where(e => e.Salary > 30000).OrderBy(e=>e.Salary).Select(e=>e);
            //foreach (var item7 in orderwheremethod)
            //{
            //    Console.WriteLine($"{item7.Name} {item7.Salary}");
            //}
            //Console.WriteLine("============================");
            //Console.WriteLine("Avg sum of all salary");
            //var avgsalaryquery = (from e in employees
            //                      select e.Salary).Average();
            //Console.WriteLine("Avg salary by query syntax"+avgsalaryquery);
            //var avgsalarymethod= employees.Select(e => e.Salary).Average();
            //Console.WriteLine("Avg slary by method" + avgsalaryquery);
            //Console.WriteLine("================================================");
            //Console.WriteLine("Max salary of IT department byquery syntax");
            //var maxsalaryquery=(from e in employees
            //                   where e.Department=="IT"
            //                   select e.Salary).Max();
            //Console.WriteLine("max salary"+maxsalaryquery);

            //Console.WriteLine("Max salary of IT department by method syntax");
            //var maxslarymethod=employees.Where(e => e.Department=="IT").Select(e=>e.Salary).Max();
            //Console.WriteLine("Max salary"+maxslarymethod);
            //var minsalaryquery = (from e in employees
            //                      select e.Salary).Min();
            //Console.WriteLine(minsalaryquery);
            //Console.ReadLine();
            //var allempquery=from emp in employees select emp;
            //foreach (Employee item1 in allempquery)
            //{
            //    Console.WriteLine(item1.Name);
            //}
            //var allempmethod = employees.Select(e => e);
            //foreach (var item2 in allempquery)
            //{
            //    Console.WriteLine(item2.Name);
            //}
            //Console.ReadLine();
            //var salaryquery= from e in employees
            //                 where e.Salary>20000
            //                 select e;
            //foreach (var item1 in salaryquery) 
            //{
            //    Console.WriteLine(item1.Name);
            //}
            //var salarymethod = employees.Where(e => e.Salary > 20000).Select(e => e.Name);
            //foreach(var item2 in salarymethod)
            //{
            //    Console.WriteLine(item2);
            //}
            //var empfinance = (from e in employees
            //                 where e.Department == "Finance"
            //                 select e).Count();
            //Console.WriteLine("Total emp in finance dept:"+empfinance);
            //Console.ReadLine();
            //var empfinancemethod = (employees.Where(e => e.Department == "Finance").Select(e => e)).Count();
            //Console.WriteLine(empfinancemethod);

            //    var maxsalaryname= (from e in employees
            //                       orderby e.Salary descending
            //                       select e.Name).FirstOrDefault();
            //    Console.WriteLine("name - "+maxsalaryname);
            //var maxslarynamemethod=employees.OrderByDescending(e=>e.Salary).Select(e=>e.Name).FirstOrDefault();
            //    Console.WriteLine("Name is "+maxslarynamemethod);
            //}
            //var avgsalaryquery = (from e in employees
            //                      where e.Department == "IT"
            //                      select e.Salary).Average();
            //Console.WriteLine("Avg slary os It dept is" + avgsalaryquery);
            //var avgsalarymethod =(employees.Where(e=>e.Department=="IT").Select(e=>e.Salary)).Average();
            //Console.WriteLine("Avg salary is"+avgsalarymethod);
            //var topthreequery=(from e in employees
            //                  orderby e.Salary descending
            //                  select e.Name).Take(3).ToList();
            //foreach (var item in topthreequery)
            //{
            //    Console.WriteLine(item);
            //}
            //var topthreemethod = employees.OrderByDescending(e => e.Salary).Select(e => e.Name).Take(3);
            //foreach (var item in topthreemethod)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
