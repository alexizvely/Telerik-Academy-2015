//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2 3
//5	1 2 3 4 5

using System;

class NumbersFromOneToN
{
    static void Main()
    {

        Console.WriteLine("Please enter a positive integer number: ");

        int input = int.Parse(Console.ReadLine());

        string output = "1";
        

        if (input != 1)
        {
            for (int i = 2; i <= input; i++)
            {

                output = string.Concat(output, " ", i.ToString());
            }
        }

        Console.WriteLine(output);

        Console.ReadKey();
    }
}

