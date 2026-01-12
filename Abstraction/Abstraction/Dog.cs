using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
     class Dog:Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
