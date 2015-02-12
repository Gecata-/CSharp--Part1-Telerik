// Problem 12. Null Values Arithmetic
// 
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;


class Null
{
    static void Main()
    {
        int? count = null;
        double? number = null;

        Console.WriteLine(count);
        Console.WriteLine(number);
        Console.WriteLine(count + 5);
        Console.WriteLine(number + null);
    }
}

