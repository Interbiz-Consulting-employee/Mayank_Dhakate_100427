class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Akku");
        Console.WriteLine(s.Name);
    }
}
