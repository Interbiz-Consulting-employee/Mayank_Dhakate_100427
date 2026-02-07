namespace ThreadTask1
{
    using System.Threading;
     class Program
    {
         void Student()
        {
            Console.WriteLine("Student method start....");
            Thread.Sleep(1000);
            Console.WriteLine("student method stop...");
        }
        static void Main(string[] args)
        {
            
            Thread t1 = new Thread(Student) { Name = "Thread1" };
            Thread t2 = new Thread(Student) { Name = "Thread2" };
            Console.WriteLine("Main Thread start");
            t1.Start();
            t2.Start();
            //t1.Join();
            //t2.Join();
            Console.WriteLine("Main thread stop");
        }
    }
}
