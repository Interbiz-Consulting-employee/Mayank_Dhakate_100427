using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent Show Method");
        }
    }

    class Child1 : Parent
    {
        public new void Show()
        {
            Console.WriteLine("Child Show Method");
        }
    }
}
