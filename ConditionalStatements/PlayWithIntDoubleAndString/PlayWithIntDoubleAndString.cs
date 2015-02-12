// Problem 9. Play with Int, Double and String
// 
// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.
// Example 1:
// 
// program	user
// Please choose a type:	
// 1 --> int	
// 2 --> double	
// 3 --> string	3
// Please enter a string:	hello
// hello*	
// Example 2:
// 
// program	user
// Please choose a type:	
// 1 --> int	
// 2 --> double	2
// 3 --> string	
// Please enter a double:	1.5
// 2.5
using System;

class PlayWithIntDoubleAndString
{
    static void Main()
        {
            Console.WriteLine("Please choose a type: \n 1 --> int \n 2 --> double \n 3 --> string");
            byte choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Convert.ToInt32(choice);
                    Console.WriteLine("Please enter an int:");
                    int count = int.Parse(Console.ReadLine());
                    Console.WriteLine(++count);
                    break;
                case 2: Convert.ToDouble(choice);
                    Console.WriteLine("Please enter a double:");
                    double countOne = double.Parse(Console.ReadLine());
                    Console.WriteLine(++countOne);
                    break;
                case 3: Console.WriteLine("Please enter a string:");
                    string word = Console.ReadLine();
                    Console.WriteLine(word + '*');
                    break;

                default:Console.WriteLine("Not a valid choice");
                    break;
            }

        }
}

