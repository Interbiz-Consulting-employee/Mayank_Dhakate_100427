using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interheritance
{
    public class B:A
    {
        public override void dashboard (int a, int b)
        {
            Console.WriteLine(a-b);
        } 
    }
}
