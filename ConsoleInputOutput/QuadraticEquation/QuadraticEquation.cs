// Problem 6. Quadratic Equation
// 
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
// Examples:
// 
// a	 b	 c	 roots
// 2	 5	 -3	 x1=-3; x2=0.5
// -1	 3	 0	 x1=3; x2=0
// -0.5	 4	 -8	 x1=x2=4
// 5	 2	 8	 no real roots
using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("a=");
        string countA = Console.ReadLine();
        double a = double.Parse(countA);

        Console.WriteLine("b=");
        string countB = Console.ReadLine();
        double b = double.Parse(countB);

        Console.WriteLine("c=");
        string countC = Console.ReadLine();
        double c = double.Parse(countC);

        
        double firstD = Math.Pow(b, 2) - (4 * a * c);
           
        if (firstD > 0)
            {
                double x2 = (-b + Math.Sqrt(firstD)) / (2 * a);
                double x1 = (-b - Math.Sqrt(firstD)) / (2 * a);
                Console.WriteLine("X1 = {0}", x1);
                Console.WriteLine("X2 = {0}", x2);
            }
        else if(firstD == 0)
            {
                double equalX = -b/(2*a);
            Console.WriteLine("x1=x2= {0}",equalX);
            }
        else
            {
                Console.WriteLine("no real roots");
            }
        
    }
}

