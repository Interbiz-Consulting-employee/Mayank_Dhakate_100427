namespace Genericc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> students = new SortedList<int, string>();

            students.Add(3, "Amit");
            students.Add(1, "Mayank");
            students.Add(2, "Rahul");
            ICollection<int> keys = students.Keys;
        }
    }
}
