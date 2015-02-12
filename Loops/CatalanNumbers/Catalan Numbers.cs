// Problem 8. Catalan Numbers
// 
// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
// Examples:
// 
// n	Catalan(n)
// 0	1
// 5	42
// 10	16796
// 15	9694845
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
       // 2n!/(n +1)!n! 

        Console.WriteLine("n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger sum = 0 ;
        BigInteger chislitel = 1;
        for (int i = 2 * n; i > n + 1; i--)    
        {
            factorial *= i;
        }
        for (int i = 1; i <= n; i++)           
        {
            chislitel *= i;
        }
        sum = factorial / chislitel;   
        Console.WriteLine(sum);
    }

}

