using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Prameter
    {
        public int id1;
        public string name1;
        public Prameter(int id1,string name1)
        {
            this.id1 = id1;
            this.name1 = name1; ;


        }
        public void show1()
        {
            Console.WriteLine("model is" + id1 + "brand is" + name1);
        }
    }
}
