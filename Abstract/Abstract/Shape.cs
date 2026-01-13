using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract class
abstract class Shape
{
    public abstract void Draw(); // no body

    public void Info()
    {
        Console.WriteLine("This is a shape");
    }
}

// Child class
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

