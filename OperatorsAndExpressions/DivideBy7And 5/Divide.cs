// Problem 3. Divide by 7 and 5
// 
// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
// Examples:
// 
// n	Divided by 7 and 5?
// 3	false
// 0	false
// 5	false
// 7	false
// 35	true
// 140	true

using System;


class Divide
{
    static void Main()
    {
        Console.WriteLine("Write Number for chek:");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        bool integer = ((number % 7) < 1) && ((number % 5) < 1);
        Console.WriteLine(number +" can be divided by 7 and 5 ?-->"+ integer);

    }
}

