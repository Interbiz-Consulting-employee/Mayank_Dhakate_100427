namespace multipledelegate
{
    public class Program
    {
        delegate void MyDelegate(int a,int b);
        static void Add(int a, int b) {
            Console.WriteLine("Sum is"+a +b);
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine("Diff is" + (a - b));
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication is" + (a*b));
        }
        static void Main(string[] args)
        {
            MyDelegate del = Add;
            del += Sub;
            del += Mul;
            del -= Sub; 
            del.Invoke(10,5);

        }
    }
}
