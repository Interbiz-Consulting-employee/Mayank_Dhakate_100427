namespace touple2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = (Name: "Mayank", age: 32, Marks: (math: 32, eng: 42, science: 88));
            Console.WriteLine("Student name is"+student.Name);
            Console.WriteLine("Student age is" + student.age);
            Console.WriteLine("Student Marks in math is" + student.Marks.math);
            Console.WriteLine("Student marks in science is" + student.Marks.science);

           
            int elementCount = student.GetType().GetFields().Length;

            Console.WriteLine($"student has {elementCount} elements.");
            Console.ReadLine();
        }
    }
}
