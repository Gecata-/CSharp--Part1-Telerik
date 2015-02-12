// Problem 7. Sum of 5 Numbers
// 
// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
// Examples:
// 
// numbers	            sum
// 1 2 3 4 5	         15
// 10 10 10 10 10	    50
// 1.5 3.14 8.2 -1 0	11.84
using System;

class Sum5Numbers
{
    static void Main()
    {
        string number = Console.ReadLine();
        string[] tokens = number.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
        double a = double.Parse(tokens[0]);
        double b = double.Parse(tokens[1]);
        double c = double.Parse(tokens[2]);
        double d = double.Parse(tokens[3]);
        double e = double.Parse(tokens[4]);
        double sum = Convert.ToDouble(a + b + c + d + e);
        Console.WriteLine("Sum = {0}", sum );

    }
}

