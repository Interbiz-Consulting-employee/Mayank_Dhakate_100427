namespace Datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "100";
            int n;
            bool result = int.TryParse(s, out n);
            Console.WriteLine(result +"Value" +n);

            int a= 100;
            string result1 = Convert.ToString(a);
            Console.WriteLine(result1);
        }
    }
}
