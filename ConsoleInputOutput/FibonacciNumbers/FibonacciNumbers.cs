// Problem 10. Fibonacci Numbers
// 
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
// Note: You may need to learn how to use loops.
// 
// Examples:
// 
// n	comments
// 1	0
// 3	0 1 1
// 10	0 1 1 2 3 5 8 13 21 34
using System;


class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                numbers[i] = 0;
            }
            else if (i == 1)
            {
                numbers[i] = 1;
            }
            else
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }

            Console.Write("{0}, ", numbers[i]);
        }
      

    }

}

