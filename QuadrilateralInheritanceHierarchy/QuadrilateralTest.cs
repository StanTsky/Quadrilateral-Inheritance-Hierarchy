using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuadrilateralTest
{
    static void Main(string[] args)
    {
        var shape1 = new Parallelogram(5, 5, 5, 5);
        var shape2 = new Trapezoid(0, 10, 10, 20, 10);
        var shape3 = new Rectangle(0, 20, 20, 30);
        var shape4 = new Square(0, 20, 15);

        Console.WriteLine(shape1);
        Console.WriteLine(shape2);
        Console.WriteLine(shape3);
        Console.WriteLine(shape4);
    }
}
