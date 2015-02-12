// Problem 2. Float or Double?
// 
// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;


class FloatOrDouble
{
    static void Main()
    {
        double bigDouble = 34.567839023;
        float  smallFloat = 12.345f;
        double secondDouble = 8923.1234857;
        float SecondFloat = 3456.091f;

        Console.WriteLine(bigDouble);
        Console.WriteLine(smallFloat);
        Console.WriteLine(secondDouble);
        Console.WriteLine(SecondFloat);

    }
}

