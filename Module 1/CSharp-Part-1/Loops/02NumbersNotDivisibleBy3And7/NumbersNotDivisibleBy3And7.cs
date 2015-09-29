//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
//Examples:

//n	    output
//3	    1 2
//10	1 2 4 5 8 10

using System;

class NumbersNotDivisibleBy3And7
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
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                    output = string.Concat(output, " ", i.ToString());

            }
        }

        Console.WriteLine(output);

        Console.ReadKey();
    }
}

