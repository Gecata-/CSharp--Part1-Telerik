// Problem 5. Third Digit is 7?
// 
// Write an expression that checks for given integer if its third digit from right-to-left is 7.
// Examples:
// 
// n	    Third digit 7?
//
// 5	    false
// 701	    true
// 9703	    true
// 877	    false
// 777877	false
// 9999799	true
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write number to be checked if its third digit from right-to-left is 7.");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        bool seven = (number / 100) %10 == 7;
        Console.WriteLine(seven);
    }
}

