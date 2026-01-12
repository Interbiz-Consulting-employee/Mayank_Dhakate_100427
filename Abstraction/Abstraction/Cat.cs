using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
     class Cat:Irun
    {
        public void run()
        {
            Console.WriteLine("Cat run slower");
        }
    }
}
