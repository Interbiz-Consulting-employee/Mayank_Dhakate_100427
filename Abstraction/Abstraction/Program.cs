namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Dog();
            a1.eat();
            a1.sound();
            Irun i1 = new Cat();
            i1.run();
            Irun i2 = new horse();  
            i2.run();
        }
    }
}
