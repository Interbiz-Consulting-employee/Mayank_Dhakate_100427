namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Parent p=new Parent();
            p.Show();
            Child1 c=new Child1();
            c.Show();
            ITest i = new Demo();
            i.Show();
            i.Display();
            ITest.Info();
            Para p1 = new Para();
        }
    }
}
