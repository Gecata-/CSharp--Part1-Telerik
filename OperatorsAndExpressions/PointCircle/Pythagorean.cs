// Problem 7. Point in a Circle
// 
// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
// Examples:
// 
// x	    y	    inside
// 0	    1	    true
// -2	    0	    true
// -1	    2	    false
// 1.5	    -1  	true
// -1.5 	-1.5	false
// 100	    -30	    false
// 0	    0	    true
// 0.2	    -0.8	true
// 0.9	    -1.93	false
// 1	    1.655	true
using System;

class PythagoreanTheorem
{
    static void Main()
    {
        //(x - center_x)^2 + (y - center_y)^2 < radius^2.
        Console.WriteLine("Write 2 points to checks if given points (x, y) are inside a circle K{0, 0}, 2:");
        string x1 = Console.ReadLine();
        string y1 = Console.ReadLine();
        double x = double.Parse(x1);
        double y = double.Parse(y1);
        int radius = 2;
        bool inside = (x*x) + (y*y) < radius;
        Console.WriteLine(inside);
    }
}

