// Problem 3. Circle Perimeter and Area
// 
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
// Examples:
// 
// r	    perimeter	area
// 2	    12.57	    12.57
// 3.5	    21.99	    38.48
using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("r =");
        string input = Console.ReadLine();
        double r = double.Parse(input);

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r,2);
        Console.WriteLine("Perimeter: {0:0.00}",perimeter);
        Console.WriteLine("Area: {0:F2}",area);
    }
}


