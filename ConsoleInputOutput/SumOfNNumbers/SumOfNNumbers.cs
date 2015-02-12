// Problem 9. Sum of n Numbers
// 
// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
// Note: You may need to use a for-loop.
// Examples:
// 
// numbers	    sum
// 3	        90
// 20	
// 60	
// 10	
// 5	        6.5
// 2	
// -1	
// -0.5	
// 4	
// 2	
// 1	        1
// 1
using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter n = ");

        double number = double.Parse(Console.ReadLine());
        double sum = 0;
        for (double n = 1; n <= number; n++)
        {
            Console.Write("Enter {0} from {1} numbers = ", n , number);
            double newNumber = double.Parse(Console.ReadLine());
            sum += newNumber;
        }
        Console.WriteLine("The sum is " + sum);
    }
}
