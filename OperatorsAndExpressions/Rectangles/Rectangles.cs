// Problem 4. Rectangles
// 
// Write an expression that calculates rectangle’s perimeter and area by given width and height.
// Examples:
// 
// width	height	perimeter	area
// 3	    4	    14	         12
// 2.5	    3	    11	         7.5
// 5	    5	    20	         25
using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Write rechtangle`s width:");
        string input = Console.ReadLine();
        float width = float.Parse(input);
        
        Console.WriteLine("Write rechtangles`s height:");
        string input2 = Console.ReadLine();
        float height = float.Parse(input2);

        float perimeter = (width * 2) + (height * 2);
        float area = width * height;
        
        Console.WriteLine("The rechtangle`s perimeter is {0} and its area is {1}", perimeter, area );
    }
}

