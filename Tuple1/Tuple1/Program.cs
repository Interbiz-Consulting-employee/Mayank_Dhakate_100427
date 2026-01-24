namespace Tuple1
{
    public class Program
    {
        static (string Name,int age,char gender)Getperson(){
            return ("Mayank",32,'M');
            }
        static void Main(string[] args)
        {
            //var person = ("Mayank", 9, 'M');
            //Console.WriteLine(person.Item1);
            //Console.WriteLine(person.Item2);
            //Console.WriteLine(person.Item3);

            //var student = (Name: "mayank", Id: 9, Age: 32, Isstudent : true);
            //Console.WriteLine(student.Name);
            //Console.WriteLine(student.Id);
            //Console.WriteLine(student.Age);
            Console.WriteLine(Getperson());
        }
    }
}
