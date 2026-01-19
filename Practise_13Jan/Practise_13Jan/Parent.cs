using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practise_13Jan
{
    public class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent method");

        }
        
    }
    public class Child : Parent
    {
        public new void show()
        {
            Console.WriteLine("new key word ");
        }
    }
}