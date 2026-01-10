namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1=new Calculator();
            c1.Calci(2, 3);
            c1.Calci("Mayank");
            Advancecalci a1= new Advancecalci();
            a1.Calci(2, 3);
        }
    }
}
