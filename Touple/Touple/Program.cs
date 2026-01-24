using static Touple.Program;

namespace Touple
{
    public static class NewClass
    {
        public static void method3(this OldClass Obj)
        {
            Console.WriteLine("Method 3");
        }
        public static void method4(this OldClass Obj)
        {
            Console.WriteLine("Method 4");
        }
    }

    public class Program
    {
        public class OldClass
        {
            public void method1(int x)
            {
                Console.WriteLine("Method 1" + x);
            }
            public void method2()
            {
                Console.WriteLine("Method 2");
            }
        }
        

        static void Main(string[] args)
            {
            OldClass obj = new OldClass();
            obj.method2();
            obj.method4();
            
           

            }
        }
    }


