using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interheritance
{
     class Multi
    {
        public void House()
        {
            Console.WriteLine("This is Grandparent house");
        }
    }
    class Parent:Multi
    {
        public void Car()
        {
            Console.WriteLine("This is my parents car");
        }
    }
    class mine:Parent
    {
        public void own()
        {
            Console.WriteLine("this my own property");
        }
    }
}
