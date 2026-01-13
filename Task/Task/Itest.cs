using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    interface ITest
    {
        void Show();

        void Display()
        {
            Console.WriteLine("Default method in interface");
        }

        static void Info()
        {
            Console.WriteLine("Static method in interface");
        }
    }

    class Demo : ITest
    {
        public void Show()
        {
            Console.WriteLine("Show implemented in class");
        }
    }
}
