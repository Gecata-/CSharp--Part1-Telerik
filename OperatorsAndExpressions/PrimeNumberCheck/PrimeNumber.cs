// Problem 8. Prime Number Check
// 
// Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive
// Examples:
// 
// n	Prime?
// 1	false
// 2	true
// 3	true
// 4	false
// 9	false
// 97	true
// 51	false
// -3	false
// 0	false
using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter positive numbern (n <= 100)");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        bool check = number > 0 ? number % number == 0 : false;
        Console.WriteLine(check);
    }
}

