using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interheritance
{
    public class Overiding
    {
        public virtual void show()
        {
            Console.WriteLine("showing");
        }
    }
    public class hi : Overiding
    {
        public override void show()
        {
            Console.WriteLine("changed");
        }
    }
}
