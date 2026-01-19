using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_13Jan
{
    public class Constructor
    {
        public Constructor() { }
        public Constructor(string name)
        {
            Console.WriteLine("Default name");
        }
        public Constructor(string name, int age)
        {
            Console.WriteLine(name + age);
        }
    }
}
