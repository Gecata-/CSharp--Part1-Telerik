// Problem 2. Gravitation on the Moon
// 
// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
// Examples:
// 
// weight	weight on the Moon
// 86	    14.62
// 74.6	    12.682
// 53.7	    9.129

using System;


class GravityMoon
{
    static void Main()
    {
        Console.WriteLine("Insert your weight:");
        string input = Console.ReadLine();
        float weight = float.Parse(input);

        float moonGravity = 0.17f;
        float moonWeight = weight * moonGravity;

        Console.WriteLine("Your weight on the Moon will be {0} kg.", moonWeight);

    }
}
