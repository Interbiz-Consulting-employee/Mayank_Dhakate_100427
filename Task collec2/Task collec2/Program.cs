using System.Collections;

namespace Task_collec2
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            
                Hashtable ht = new Hashtable();
                ht.Add("A", 100);
                ht.Add("B", 100);
                ht.Add("C", 200);

                int searchValue = 100;
                Console.WriteLine("Keys with value 100:");

                
                foreach (var key in ht.Keys)
                {
                    if ((int)ht[key] == searchValue)
                        Console.WriteLine(key);
                }
            
        }
    }
}
