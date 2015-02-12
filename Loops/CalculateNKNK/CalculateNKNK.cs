// Problem 7. Calculate N! / (K! * (N-K)!)
// 
// In combinatorics, the number of ways to choose k different members out of a group of n different elements
// (also known as the number of combinations) is calculated by the following formula: formula For example,
// there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
// Examples:
// 
// n	k	n! / (k! * (n-k)!)
// 3	2	3
// 4	2	6
// 10	6	210
// 52	5	2598960
using System;
using System.Numerics;

class CalculateNKNK
{
    static void Main()
    {
        Console.WriteLine("1 < k < n < 100");
        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("k=");
        int k = int.Parse(Console.ReadLine());
        double result = 1;
        double num = n - k;
        double a = 1;
        double b = 1;
        

        if (k > 1 && n < 100)
        {
            // n! / (k! * (n-k)!)
            // n!/k!*n!-k!*k!
            // k!*n! - k!*k! = \ k!*n! =k!k! \  n!=k! \ n!-k!
            for (int i = 1; i <= num; i++)
            {
                b *= i;
               
            }
            for (int j = k + 1; j <= n; j++)
            {
                a *= j;

            }
            result = a / b;
        }
        else
        {
            Console.WriteLine("wrong number");
        }
        Console.WriteLine(result);
    }
}
