//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	                sum
//1 2 3 4 5	                15
//10 10 10 10 10	        50
//1.5 3.14 8.2 -1 0	        11.84

using System;
using System.Globalization;

class SumOfFiveNumbers
{
    static void Main()
    {
        CultureInfo invC = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter five numbers (please separate the numbers with space): ");
        double sum = 0;

        for (int i = 0; i < 3; i++)
        {
            /// the following "Parse(string, invC)" removes the issue with the different delimiter
            sum += double.Parse(Console.ReadLine(), invC);
        }

        Console.WriteLine("The sum of the five numbers is {0}", sum);

        Console.WriteLine("Sum = " + sum);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

