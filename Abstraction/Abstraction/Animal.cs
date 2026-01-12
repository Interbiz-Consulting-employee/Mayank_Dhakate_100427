using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public void eat()
        {
            Console.WriteLine("all animal eat some thing");
            
        }
        public abstract void sound();
    }
}
