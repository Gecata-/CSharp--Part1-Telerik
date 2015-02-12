// Problem 4. Number Comparer
// 
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.
// Examples:
// 
// a	    b	    greater
// 5	    6	    6
// 10	    5	    10
// 0	    0	    0
// -5	    -2	    -2
// 1.5	    1.6 	1.6
using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("a= ");
            string countA = Console.ReadLine();
            float a = float.Parse(countA);

            Console.WriteLine("b= ");
            string countB = Console.ReadLine();
            float b = float.Parse(countB);

            float greatNum = Math.Max(a, b);
            Console.WriteLine("The greater is: " + greatNum);
        }
    }

