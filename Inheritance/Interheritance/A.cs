using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interheritance
{
    public class A
    {
        //constructor overloading
        //public A(int a, int b)
        //{
            
        //}
        //public A(int a,int b,int c)
        //{
            
        //}
        //method overloading

        public virtual void dashboard(int a, int b)
        {
            Console.WriteLine($"Score: {a},Wickets: {b}");
        }
        public void dashboard(int a, int b, int c)
        {
            Console.WriteLine($"Score: {a},Wickets: {b},Target: {c}");
        }

      /*  public void add(string a,string b)
        {
            Console.WriteLine(a+b);
        }
        public void add(char a,int d)
        {
            Console.WriteLine(a+d);
        }*/
    }
}
