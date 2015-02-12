// Problem 1. Declare Variables
// 
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;


class Variables
{
    static void Main()
    {
        int number = 52130 ;
        sbyte seconNumber = -115 ;
        long thirdNumber = 4825932 ;
        byte fourthNumber = 97 ;
        int fifthNumber = -10000 ;
       


            Console.WriteLine(number);
            Console.WriteLine(seconNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
            Console.WriteLine(fifthNumber);
    }
}

