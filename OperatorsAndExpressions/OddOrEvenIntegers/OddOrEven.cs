// Problem 1. Odd or Even Integers
// 
// Write an expression that checks if given integer is odd or even.
// Examples:
// 
// n	Odd?
// 3	true
// 2	false
// -2	false
// -1	true
// 0	false

using System;



class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Input number:");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        bool odd = (number % 2) != 0;

        Console.WriteLine("The number {0} is Odd ? {1}", number, odd);
    }
}

