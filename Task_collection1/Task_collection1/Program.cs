namespace Task_collection1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list.Capacity);
            list.AddRange(new int[] { 7, 22, 31 });
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Insert(2, 5);
            //list.Remove(22);
            //list.RemoveAt(2);
            //list.RemoveRange(2, 4);
            Console.WriteLine(list.Contains(1));
            Console.WriteLine(list.IndexOf(4));
            List<int> found = list.FindAll(x => x > 2);
            list.Sort();
            
            list.Add(6);
            list.Sort();
            list.Reverse();
            foreach (int x in list)
            {
                Console.WriteLine("list:" + x);
            }
        }
    }
}
