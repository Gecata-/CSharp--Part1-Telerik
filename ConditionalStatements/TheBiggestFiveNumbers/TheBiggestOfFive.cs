// Problem 6. The Biggest of Five Numbers
// 
// Write a program that finds the biggest of five numbers by using only five if statements.
// Examples:
// 
// a	b	     c	     d	   e	 biggest
// 5	2	     2	     4	   1	 5
// -2	-22	     1	     0	   0	 1
// -2	4	     3	     2	   0	 4
// 0	-2.5     0	     5	   5	 5
// -3	-0.5	-1.1	-2	-0.1	-0.1
using System;


class TheBiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("a=");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("c=");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("d=");
        float d = float.Parse(Console.ReadLine());
        Console.WriteLine("e=");
        float e = float.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c && b >= e && b >= d)
        {
            Console.WriteLine(b);
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= a && d >= b && c <= d && d >= e)
        {
            Console.WriteLine(d);
        }
        else if (e >= a && e >= b && e >= d && c <= e)
        {
            Console.WriteLine(e);
        }
    }
}

