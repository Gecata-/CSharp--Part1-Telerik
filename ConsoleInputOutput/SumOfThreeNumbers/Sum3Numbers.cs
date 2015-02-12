// Problem 1. Sum of 3 Numbers
// 
// Write a program that reads 3 real numbers from the console and prints their sum.
// Examples:
// 
// a	    b	     c	    sum
// 3	    4	     11	    18
// -2	    0	     3	    1
// 5.5	    4.5 	 20.1   30.1
using System;


class Sum3Numbers
{
    static void Main()
    {
        string inputA = Console.ReadLine();
        double a = double.Parse(inputA);

        string inputB = Console.ReadLine();
        double b = double.Parse(inputB);

        string inputC = Console.ReadLine();
        double c = double.Parse(inputC);

        Console.WriteLine("sum = "+ (a + b + c));

    }
}

