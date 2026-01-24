namespace Lambdatouple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<(int, int,string)> getValues = () => (10,20,"Done");
            var result = getValues();
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);

            Func<(int sum ,int product)> Cal =()=>(5+5,5*5);
            var result1 = Cal();
            Console.WriteLine(result1.sum);
            Console.WriteLine(result1.product);
            List<(int a, string name)> student = () => (1, "Mayank");
           
        }
    }
}
