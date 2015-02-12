// Problem 10. Point Inside a Circle & Outside of a Rectangle
// 
// Write an expression that checks for given point (x, y) 
// if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
// Examples:
// 
// x	    y	    inside K & outside of R
// 1	    2	    yes
// 2.5	    2	    no
// 0	    1	    no
// 2.5	    1	    no
// 2	    0	    no
// 4	    0	    no
// 2.5	    1.5	    no
// 2	    1.5	    yes
// 1	    2.5	    yes
// -100	    -100    no
using System;

class PointInAndOut
{
    static void Main()
        
    {
        //(x - center_x)^2 + (y - center_y)^2 < radius^2.
        Console.WriteLine("Write 2 points to checks if given points (x, y) are inside a circle K{1, 1}, 1.5:");
        string x1 = Console.ReadLine();
        string y1 = Console.ReadLine();
        double x = double.Parse(x1);
        double y = double.Parse(y1);
        double radius = 1.5;
        bool insideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius;
        bool isOutsideRectangle = x > 1 || x < 5 && y > -1 || y < 1;
        
        if (x == 0 || y == 0)
        {
        Console.WriteLine("no");
        }
        else if (insideCircle == true && isOutsideRectangle == true)
        {
        Console.WriteLine("yes");
        }
        else
        {
        Console.WriteLine("no");
        }
    }

}

