// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
// 
// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.
// Examples:
// 
// n	x	S
// 3	2	2.75000
// 4	3	2.07407
// 5	-4	0.75781
using System;
using System.Numerics;
class Calculate
{
    static void Main()
    {
        Console.WriteLine("n=");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("x=");
        double x = double.Parse(Console.ReadLine());

        double dChislitel = 1; // 
        double dZnamenatel = 1;

        double sum = 0;

        sum += 1; // израза започва със 1 + ...

        for (int i = 1; i <= n; i++)
        {
            dChislitel = dChislitel * i; // всеки път числителя се умножава с i
            dZnamenatel = dZnamenatel * x; // в знаменателя x се вдига с още една степен на x

            sum += dChislitel / dZnamenatel;
        }



        Console.WriteLine("{0:F5}", sum);
        Console.ReadKey();
        //Console.WriteLine("n=");
        //double n = double.Parse(Console.ReadLine());
        //Console.WriteLine("x=");
        //double x = double.Parse(Console.ReadLine());

        //double factorial = 1;
        //double sum = 1;

        //for (int i = 1; i <= n; i++)
        //{


        //    // S = 1 + 1!/x + 2!/x2 + … + n!/x^n.

        //    factorial *= i;
        //    sum += (factorial / (Math.Pow(x, i)));

        //}


        //Console.WriteLine("{0:F5}", sum);

    }
}

