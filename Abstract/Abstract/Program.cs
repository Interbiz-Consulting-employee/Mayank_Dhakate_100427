namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            {
                Shape s = new Circle();  // abstract reference, child object
                s.Draw();
                s.Info();
            }
        }
    }
}
