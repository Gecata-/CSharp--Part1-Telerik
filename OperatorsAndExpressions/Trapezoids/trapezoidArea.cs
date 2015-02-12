// Problem 9. Trapezoids
// 
// Write an expression that calculates trapezoid's area by given sides a and b and height h.
// Examples:
// 
// a	    b	    h	    area
// 5	    7	    12	    72
// 2	    1	    33	    49.5
// 8.5	    4.3	    2.7	    17.28
// 100	    200	    300	    45000
// 0.222	0.333	0.555	0.1540125
using System;


class Trapezoid
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Write Trapzoid`s side ""a"":");
        string sideA = Console.ReadLine();
        double a = double.Parse(sideA);
        Console.WriteLine("Write Trapzoid`s side \"b\":");
        string sideB = Console.ReadLine();
        double b = double.Parse(sideB);
        Console.WriteLine("Write Trapzoid`s height:"); 
        string sideH = Console.ReadLine();

        double h = double.Parse(sideH);
        double area = (0.5*(a+b))*h;
        Console.WriteLine(" The trapezoid's area is: " + area);      
    }
}

