// Problem 6. Calculate N! / K!
// 
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.
// Examples:
// 
// n	k	n! / k!
// 5	2	60
// 6	5	6
// 8	3	6720
using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("1 < k < n < 100");
        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("k=");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
       
        if (n <= 100 && k > 1)
        {
            for (int i = k +1 ; i <= n; i++)
            {
                result *= i;
            }

        }
        else
        {
            Console.WriteLine("Wrong Input!");
        }
        Console.WriteLine("n!/k!={0}",result);
    }
}


