using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Mobile
     

    {
        public int id;
        public string name;

        public Mobile()
        {
            id = 99;
            name = "apple";

        }
        public void Display()
        {
            Console.WriteLine("Model of phone is" + id + "Brand is" + name);
        }
    }
}
