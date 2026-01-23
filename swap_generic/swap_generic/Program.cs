namespace swap_generic
{
    public  class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a=b; 
            b=temp;
        }
        static void Main(string[] args)
        {
            object num = 9;
            object name = "mayank";
            Console.WriteLine("Before swap num is"+num+"and name is"+name);
            Swap(ref num, ref name);
            Console.WriteLine("After swap num is" + num + "and name is" + name);

        }
    }
}
