// Problem 5. The Biggest of 3 Numbers
// 
// Write a program that finds the biggest of three numbers.
// Examples:
// 
// a	b	    c	    biggest
// 5	2	    2	    5
// -2	-2	    1	    1
// -2	4	    3	    4
// 0	-2.5	5	    5
// -0.1	-0.5	-1.1	-0.1
using System;

class TheBiggest3Numbers
{
    static void Main()
    {
        Console.WriteLine("a=");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("c=");
        float c = float.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

